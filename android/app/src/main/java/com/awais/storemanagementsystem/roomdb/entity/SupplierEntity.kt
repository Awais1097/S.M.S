package com.awais.storemanagementsystem.roomdb.entity

import androidx.room.ColumnInfo
import androidx.room.Entity
import androidx.room.PrimaryKey
import com.awais.storemanagementsystem.roomdb.entity.SupplierEntity.Companion.TABLE_SUPPLIER

@Entity(tableName = TABLE_SUPPLIER)

class SupplierEntity(
    @PrimaryKey(autoGenerate = true) var _id: Int? = null,
    @ColumnInfo(name = COL_BRANDNAME) var col_name: String? = null,
    @ColumnInfo(name = COL_ID) var col_id: String? = null,
    @ColumnInfo(name = COL_IMAGE) var col_imge: String? = null,
    @ColumnInfo(name = COL_COMPANYNAME) var col_comp_name: String? = null,
    @ColumnInfo(name = COL_CITY) var col_city: String? = null,
    @ColumnInfo(name = COL_COUNTRY) var col_country: String? = null,
    @ColumnInfo(name = COL_ADDRESS) var col_address: String? = null,
    @ColumnInfo(name = COL_LAT) var col_lat: Double? = 0.0,
    @ColumnInfo(name = COL_LNG) var col_lng: Double? = 0.0,
    @ColumnInfo(name = COL_PHONE_NUMER) var col_phone: String? = null,
    @ColumnInfo(name = COL_MOBILE_NUMER) var col_mobile: String? = null,
) {
    companion object {
        const val TABLE_SUPPLIER = "Suppliers"
        const val COL_BRANDNAME = "SupplierName"
        const val COL_ID = "SupplierId"
        const val COL_COMPANYNAME = "SupplierCompName"
        const val COL_IMAGE = "SupplierImage"
        const val COL_CITY = "SupplierCity"
        const val COL_COUNTRY = "SupplierCountry"
        const val COL_ADDRESS = "SupplierAddress"
        const val COL_LAT = "SupplierLat"
        const val COL_LNG = "SupplierLng"
        const val COL_PHONE_NUMER = "SupplierPhoneNumber"
        const val COL_MOBILE_NUMER = "SupplierMobileNumber"
    }

}