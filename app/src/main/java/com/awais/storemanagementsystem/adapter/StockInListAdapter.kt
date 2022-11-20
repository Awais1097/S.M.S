package com.awais.storemanagementsystem.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.core.view.isVisible
import androidx.recyclerview.widget.RecyclerView
import com.awais.storemanagementsystem.R
import com.awais.storemanagementsystem.databinding.ItemNotificationBinding
import com.awais.storemanagementsystem.roomdb.entity.StockInEntity

class StockInListAdapter(var list : List<StockInEntity>,var onItemClick: OnItemClick) : RecyclerView.Adapter<StockInListAdapter.ViewHolder>() {

    class ViewHolder(var binding: ItemNotificationBinding): RecyclerView.ViewHolder(binding.root)

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ViewHolder {
        return ViewHolder(
            ItemNotificationBinding.inflate(
                LayoutInflater.from(parent.context),parent,false
            )
        )
    }

    override fun onBindViewHolder(holder: ViewHolder, position: Int) {
        val item = list[position]
        holder.binding.tvNoticeTitle.text = item.col_productName
        holder.binding.tvNoticeDate.text = "QTY: " + item.col_qty.toString()
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
        fun onDelete(item: StockInEntity)
        fun onClick(item: StockInEntity)
    }

}