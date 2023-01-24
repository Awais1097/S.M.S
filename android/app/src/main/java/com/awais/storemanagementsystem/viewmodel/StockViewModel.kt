package com.awais.storemanagementsystem.viewmodel

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.awais.storemanagementsystem.roomdb.AppDatabase
import com.awais.storemanagementsystem.roomdb.entity.ProductEntity
import com.awais.storemanagementsystem.roomdb.entity.StockInEntity
import com.awais.storemanagementsystem.roomdb.entity.SupplierEntity

class StockViewModel : ViewModel() {

    private val _list = MutableLiveData<List<StockInEntity>>().apply {
        value = AppDatabase.get().stcockInDao().getAll()
    }
    val list: LiveData<List<StockInEntity>> = _list

    fun getAll() {
        _list.value = AppDatabase.get().stcockInDao().getAll()
    }

    private val _list_products = MutableLiveData<List<ProductEntity>>().apply {
        value = AppDatabase.get().productsDao().getAll()
    }
    val list_pro: LiveData<List<ProductEntity>> = _list_products

    fun getAllProducts() {
        _list_products.value = AppDatabase.get().productsDao().getAll()
    }

    private val _list_sullpier = MutableLiveData<List<SupplierEntity>>().apply {
        value = AppDatabase.get().supplierDao().getAll()
    }
    val list_sup: LiveData<List<SupplierEntity>> = _list_sullpier

    fun getAllSupplier() {
        _list_sullpier.value = AppDatabase.get().supplierDao().getAll()
    }

}