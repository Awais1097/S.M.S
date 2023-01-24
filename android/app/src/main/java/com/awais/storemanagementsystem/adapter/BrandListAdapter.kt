package com.awais.storemanagementsystem.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.awais.storemanagementsystem.databinding.ItemNotificationBinding
import com.awais.storemanagementsystem.roomdb.entity.BrandEntity
import com.awais.storemanagementsystem.util.Utilities
import com.bumptech.glide.Glide

class BrandListAdapter(var list : List<BrandEntity>,var onItemClick: OnItemClick) : RecyclerView.Adapter<BrandListAdapter.ViewHolder>() {

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
        holder.binding.tvNoticeTitle.text = item.col_branchname
        holder.binding.tvNoticeDate.text = item._id.toString()
        if (item.col_imge != null) {
            Glide.with(holder.itemView.context).load(Utilities.decode(item.col_imge!!)).centerCrop()
                .into(holder.binding.ivRecentNotice)
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
        fun onDelete(item: BrandEntity)
        fun onClick(item: BrandEntity)
    }

}