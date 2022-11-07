package com.awais.storemanagementsystem.adapter

import android.annotation.SuppressLint
import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.core.view.isVisible
import androidx.recyclerview.widget.RecyclerView
import com.awais.storemanagementsystem.R
import com.awais.storemanagementsystem.databinding.ItemNotificationBinding
import com.awais.storemanagementsystem.roomdb.entity.CustomerEntity
import com.awais.storemanagementsystem.util.Utilities
import com.bumptech.glide.Glide

class CustomerAdapter(var list: List<CustomerEntity>, var onItemClick: OnItemClick) :
    RecyclerView.Adapter<CustomerAdapter.ViewHolder>() {

    class ViewHolder(var binding: ItemNotificationBinding) : RecyclerView.ViewHolder(binding.root)

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ViewHolder {
        return ViewHolder(
            ItemNotificationBinding.inflate(
                LayoutInflater.from(parent.context), parent, false
            )
        )
    }

    @SuppressLint("UseCompatLoadingForDrawables", "SetTextI18n")
    override fun onBindViewHolder(holder: ViewHolder, position: Int) {
        val item = list[position]
        holder.binding.tvNoticeTitle.text = item.col_id +" - "+ item.col_name
        holder.binding.tvNoticeDate.text = item.col_city.toString()
        holder.binding.imageViewPring.isVisible = true
        holder.binding.imageView.setImageDrawable(holder.itemView.context.getDrawable(R.drawable.rank_icon))
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
        holder.binding.imageViewPring.setOnClickListener {
            onItemClick.onPrint(item)
        }
    }

    override fun getItemCount(): Int {
        return list.size
    }

    interface OnItemClick {
        fun onDelete(item: CustomerEntity)
        fun onClick(item: CustomerEntity)
        fun onPrint(item: CustomerEntity)
    }

}