package com.awais.storemanagementsystem.adapter

import android.annotation.SuppressLint
import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.awais.storemanagementsystem.adapter.items.ProductListItem
import com.awais.storemanagementsystem.databinding.ItemProductListBinding
import com.awais.storemanagementsystem.databinding.TextItemLayoutBinding
import com.awais.storemanagementsystem.roomdb.entity.ProductEntity
import com.awais.storemanagementsystem.util.Utilities
import com.bumptech.glide.Glide

class ProductsListAdapter(var list : List<ProductListItem>) : RecyclerView.Adapter<RecyclerView.ViewHolder>() {

    class ViewHolder(var binding: ItemProductListBinding): RecyclerView.ViewHolder(binding.root)
    class GroupViewHolder(var binding: TextItemLayoutBinding): RecyclerView.ViewHolder(binding.root)

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): RecyclerView.ViewHolder {
        return if (viewType == ProductListItem.TYPE_GROUP){
            GroupViewHolder(
                TextItemLayoutBinding.inflate(
                    LayoutInflater.from(parent.context),parent,false
                )
            )
        }else{
            ViewHolder(
                ItemProductListBinding.inflate(
                    LayoutInflater.from(parent.context),parent,false
                )
            )
        }
    }

    @SuppressLint("SetTextI18n")
    override fun onBindViewHolder(holder: RecyclerView.ViewHolder, position: Int) {
        val data = list[position]
        val item = data.item
        if(data.type == ProductListItem.TYPE_GROUP){
            holder as GroupViewHolder
            item as String
            holder.binding.text1.text = item
        }else{
            holder as ViewHolder
            item as ProductEntity
            holder.binding.description3Tv.text =item.col_productid+" - "+ item.col_productname
            holder.binding.description2Tv.text = "Price: "+ item.col_unitprice.toString()
            holder.binding.description4Tv.text = "Size: "+ item.col_unitsize.toString()
            holder.binding.description6Tv.text = "Rack: "+ item.col_rackname.toString()
            if (item.col_img != null) {
                Glide.with(holder.itemView.context).load(Utilities.decode(item.col_img!!)).centerCrop()
                    .into(holder.binding.itemImage)
            }
        }
    }

    override fun getItemCount(): Int {
        return list.size
    }

    override fun getItemViewType(position: Int): Int {
        return list[position].type
    }

}