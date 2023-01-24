package com.awais.storemanagementsystem.ui.slideshow

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.awais.storemanagementsystem.roomdb.AppDatabase
import com.awais.storemanagementsystem.roomdb.entity.CompanyEntity
import com.awais.storemanagementsystem.roomdb.entity.CustomerEntity

class SlideshowViewModel : ViewModel() {

    private val _list = MutableLiveData<List<CompanyEntity>>().apply {
        value = AppDatabase.get().companyDao().getAll()
    }
    val list: LiveData<List<CompanyEntity>> = _list

    fun getAll(){
        _list.value = AppDatabase.get().companyDao().getAll()
    }

}