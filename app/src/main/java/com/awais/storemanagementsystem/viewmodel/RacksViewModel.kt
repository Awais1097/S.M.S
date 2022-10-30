package com.awais.storemanagementsystem.viewmodel

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.awais.storemanagementsystem.roomdb.AppDatabase
import com.awais.storemanagementsystem.roomdb.entity.BrandEntity
import com.awais.storemanagementsystem.roomdb.entity.RacksEntity

class RacksViewModel : ViewModel() {

    private val _list = MutableLiveData<List<RacksEntity>>().apply {
        value = AppDatabase.get().racksDao().getAll()
    }
    val list: LiveData<List<RacksEntity>> = _list

    fun getAll(){
        _list.value = AppDatabase.get().racksDao().getAll()
    }

}