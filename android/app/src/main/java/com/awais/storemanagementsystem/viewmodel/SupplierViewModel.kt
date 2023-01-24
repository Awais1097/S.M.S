package com.awais.storemanagementsystem.viewmodel

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.awais.storemanagementsystem.roomdb.AppDatabase
import com.awais.storemanagementsystem.roomdb.entity.SupplierEntity

class SupplierViewModel : ViewModel() {

    private val _list = MutableLiveData<List<SupplierEntity>>().apply {
        value = AppDatabase.get().supplierDao().getAll()
    }
    val list: LiveData<List<SupplierEntity>> = _list

    fun getAll() {
        _list.value = AppDatabase.get().supplierDao().getAll()
    }

}