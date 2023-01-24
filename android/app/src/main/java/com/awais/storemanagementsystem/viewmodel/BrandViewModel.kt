package com.awais.storemanagementsystem.viewmodel

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.awais.storemanagementsystem.roomdb.AppDatabase
import com.awais.storemanagementsystem.roomdb.entity.BrandEntity

class BrandViewModel : ViewModel() {

    private val _list = MutableLiveData<List<BrandEntity>>().apply {
        value = AppDatabase.get().brandsDao().getAll()
    }
    val list: LiveData<List<BrandEntity>> = _list

    fun getAllBrands(){
        _list.value = AppDatabase.get().brandsDao().getAll()
    }

}