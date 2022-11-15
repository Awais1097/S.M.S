package com.awais.storemanagementsystem.viewmodel

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.awais.storemanagementsystem.roomdb.AppDatabase
import com.awais.storemanagementsystem.roomdb.entity.BrandEntity
import com.awais.storemanagementsystem.roomdb.entity.Categoryntity

class CategoryViewModel : ViewModel() {

    private val _list = MutableLiveData<List<Categoryntity>>().apply {
        value = AppDatabase.get().categoryDao().getAll()
    }
    val list: LiveData<List<Categoryntity>> = _list

    fun getAllBrands(){
        _list.value = AppDatabase.get().categoryDao().getAll()
    }

}