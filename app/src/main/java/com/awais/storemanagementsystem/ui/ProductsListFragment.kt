package com.awais.storemanagementsystem.ui

import androidx.lifecycle.ViewModelProvider
import com.awais.storemanagementsystem.adapter.ProductsListAdapter
import com.awais.storemanagementsystem.roomdb.entity.ProductEntity
import com.awais.storemanagementsystem.viewmodel.ProductsViewModel

class ProductsListFragment : BaseListFragment() {


    override fun loadData() {
        val viewModel =
            ViewModelProvider(this)[ProductsViewModel::class.java]
        viewModel.getAllProducts()
        viewModel.list.observe(viewLifecycleOwner) {
            binding.list.adapter = ProductsListAdapter(it,
                onItemClick = object : ProductsListAdapter.OnItemClick {

                    override fun onDelete(item: ProductEntity) {

                    }

                    override fun onClick(item: ProductEntity) {

                    }
                }
            )
        }
    }

    override fun showFab(): Boolean {
        return false
    }

    companion object {
        val TAG: String = ProductsListFragment::class.java.name
    }


}