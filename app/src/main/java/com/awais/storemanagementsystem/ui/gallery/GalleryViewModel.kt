package com.awais.storemanagementsystem.ui.gallery

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.awais.storemanagementsystem.roomdb.AppDatabase
import com.awais.storemanagementsystem.roomdb.entity.CustomerEntity
import com.awais.storemanagementsystem.roomdb.entity.RacksEntity

class GalleryViewModel : ViewModel() {

    private val _list = MutableLiveData<List<CustomerEntity>>().apply {
        value = AppDatabase.get().customerDao().getAll()
    }
    val list: LiveData<List<CustomerEntity>> = _list

    fun getAll(){
        _list.value = AppDatabase.get().customerDao().getAll()
    }

}