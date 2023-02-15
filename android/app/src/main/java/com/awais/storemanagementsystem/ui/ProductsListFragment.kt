package com.awais.storemanagementsystem.ui

import android.os.Bundle
import android.view.Menu
import android.view.MenuInflater
import android.view.MenuItem
import androidx.core.view.isVisible
import androidx.lifecycle.ViewModelProvider
import com.awais.storemanagementsystem.R
import com.awais.storemanagementsystem.adapter.ProductsListAdapter
import com.awais.storemanagementsystem.adapter.items.ProductListItem
import com.awais.storemanagementsystem.roomdb.entity.ProductEntity
import com.awais.storemanagementsystem.viewmodel.ProductsViewModel

class ProductsListFragment : BaseListFragment() {

    var groupId : Int = 0
    var list :  List<ProductEntity>? = null
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setHasOptionsMenu(true)
    }

    override fun loadData() {
        val viewModel = ViewModelProvider(this)[ProductsViewModel::class.java]
        groupId = R.id.action_company
        viewModel.getAllProducts()
        viewModel.list.observe(viewLifecycleOwner) {
            list = it
            groupProducts()
        }
    }

    override fun showFab(): Boolean {
        return false
    }

    companion object {
        val TAG: String = ProductsListFragment::class.java.name
    }

    override fun onCreateOptionsMenu(menu: Menu, inflater: MenuInflater) {
        inflater.inflate(R.menu.menu_product_list, menu)
        super.onCreateOptionsMenu(menu, inflater)
    }

    override fun onOptionsItemSelected(item: MenuItem): Boolean {
        groupId = item.itemId
        groupProducts()
        return super.onOptionsItemSelected(item)
    }

    private fun groupProducts(){
        val gList = list?.groupBy {
            when(groupId){
                R.id.action_category -> it.col_categoryid
                R.id.action_rack -> it.col_rackid
                R.id.action_brand -> it.col_brandid
                else -> it.col_compid
            }
        }
        val mList : ArrayList<ProductListItem> = ArrayList()
        gList?.keys?.forEach {g->
            mList.add(ProductListItem(g ?:"",ProductListItem.TYPE_GROUP))
            gList[g]?.forEach {pro->
                mList.add(ProductListItem(pro ,ProductListItem.TYPE_PRODUCT))
            }
        }
        binding.list.adapter = ProductsListAdapter(mList)
        binding.empty.isVisible = mList.isEmpty()
    }


}