package com.awais.storemanagementsystem.adapter

import android.annotation.SuppressLint
import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.awais.storemanagementsystem.databinding.ItemProductListBinding
import com.awais.storemanagementsystem.roomdb.entity.ProductEntity
import com.awais.storemanagementsystem.util.Utilities
import com.bumptech.glide.Glide

class ProductsListAdapter(var list : List<ProductEntity>, var onItemClick: OnItemClick) : RecyclerView.Adapter<ProductsListAdapter.ViewHolder>() {

    class ViewHolder(var binding: ItemProductListBinding): RecyclerView.ViewHolder(binding.root)

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ViewHolder {
        return ViewHolder(
            ItemProductListBinding.inflate(
                LayoutInflater.from(parent.context),parent,false
            )
        )
    }

    @SuppressLint("SetTextI18n")
    override fun onBindViewHolder(holder: ViewHolder, position: Int) {
        val item = list[position]
        holder.binding.description3Tv.text =item.col_productid+" - "+ item.col_productname
        holder.binding.description2Tv.text = "Price: "+ item.col_unitprice.toString()
        holder.binding.description4Tv.text = "Size: "+ item.col_unitsize.toString()
        holder.binding.description6Tv.text = "Rack: "+ item.col_rackname.toString()
        if (item.col_img != null) {
            Glide.with(holder.itemView.context).load(Utilities.decode(item.col_img!!)).centerCrop()
                .into(holder.binding.itemImage)
        }
        holder.binding.doDelete.setOnClickListener {
            onItemClick.onDelete(item)
        }
        holder.itemView.setOnClickListener {
            onItemClick.onClick(item)
        }
    }

    override fun getItemCount(): Int {
        return list.size
    }

    interface OnItemClick{
        fun onDelete(item: ProductEntity)
        fun onClick(item: ProductEntity)
    }

}