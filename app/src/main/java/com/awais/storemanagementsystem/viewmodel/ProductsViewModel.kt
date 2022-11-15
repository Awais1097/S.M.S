package com.awais.storemanagementsystem.viewmodel

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.awais.storemanagementsystem.roomdb.AppDatabase
import com.awais.storemanagementsystem.roomdb.entity.*

class ProductsViewModel : ViewModel() {

    private val _list = MutableLiveData<List<ProductEntity>>().apply {
        value = AppDatabase.get().productsDao().getAll()
    }
    val list: LiveData<List<ProductEntity>> = _list

    fun getAllProducts() {
        _list.value = AppDatabase.get().productsDao().getAll()
    }

    private val _list_rack = MutableLiveData<List<RacksEntity>>().apply {
        value = AppDatabase.get().racksDao().getAll()
    }
    val list_rack: LiveData<List<RacksEntity>> = _list_rack

    fun getAllRack() {
        _list_rack.value = AppDatabase.get().racksDao().getAll()
    }


    private val _list_brand = MutableLiveData<List<BrandEntity>>().apply {
        value = AppDatabase.get().brandsDao().getAll()
    }
    val list_brand: LiveData<List<BrandEntity>> = _list_brand

    fun getAllBrands() {
        _list_brand.value = AppDatabase.get().brandsDao().getAll()
    }

    private val _list_catg = MutableLiveData<List<Categoryntity>>().apply {
        value = AppDatabase.get().categoryDao().getAll()
    }
    val list_catg: LiveData<List<Categoryntity>> = _list_catg

    fun getAllCategory() {
        _list_catg.value = AppDatabase.get().categoryDao().getAll()
    }

    private val _list_comp = MutableLiveData<List<CompanyEntity>>().apply {
        value = AppDatabase.get().companyDao().getAll()
    }
    val list_comp: LiveData<List<CompanyEntity>> = _list_comp

    fun getAllCompany() {
        _list_comp.value = AppDatabase.get().companyDao().getAll()
    }

}