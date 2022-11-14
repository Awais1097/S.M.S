package com.awais.storemanagementsystem.viewmodel

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.awais.storemanagementsystem.roomdb.AppDatabase
import com.awais.storemanagementsystem.roomdb.entity.BrandEntity
import com.awais.storemanagementsystem.roomdb.entity.ProductEntity

class ProductsViewModel : ViewModel() {

    private val _list = MutableLiveData<List<ProductEntity>>().apply {
        value = AppDatabase.get().productsDao().getAll()
    }
    val list: LiveData<List<ProductEntity>> = _list

    fun getAll() {
        _list.value = AppDatabase.get().productsDao().getAll()
    }

}