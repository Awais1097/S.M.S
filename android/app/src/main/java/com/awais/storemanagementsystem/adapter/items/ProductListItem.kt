package com.awais.storemanagementsystem.adapter.items

data class ProductListItem(var item : Any, var type: Int){
    companion object{
        const val TYPE_GROUP = 1
        const val TYPE_PRODUCT = 1
    }
}