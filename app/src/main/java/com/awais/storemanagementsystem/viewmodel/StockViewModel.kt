package com.awais.storemanagementsystem.viewmodel

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.awais.storemanagementsystem.roomdb.AppDatabase
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

}