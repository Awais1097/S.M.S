package com.awais.storemanagementsystem.roomdb.entity

import androidx.room.ColumnInfo
import androidx.room.Entity
import androidx.room.PrimaryKey
import com.awais.storemanagementsystem.roomdb.entity.CustomerEntity.Companion.TABLE_CUSTOMER

@Entity(tableName = TABLE_CUSTOMER)
class CustomerEntity(
    @PrimaryKey(autoGenerate = true) var _id: Int? = null,
    @ColumnInfo(name = COL_BRANDNAME) var col_name: String? = null,
    @ColumnInfo(name = COL_ID) var col_id: String? = null,
    @ColumnInfo(name = COL_IMAGE) var col_imge: String? = null,
    @ColumnInfo(name = COL_REMARKS) var col_remarks: String? = null,
    @ColumnInfo(name = COL_CITY) var col_city: String? = null,
    @ColumnInfo(name = COL_COUNTRY) var col_country: String? = null,
    @ColumnInfo(name = COL_ADDRESS) var col_address: String? = null,
    @ColumnInfo(name = COL_LAT) var col_lat: Double? = 0.0,
    @ColumnInfo(name = COL_LNG) var col_lng: Double? = 0.0,
    @ColumnInfo(name = COL_PHONE_NUMER) var col_phone: String? = null,
    @ColumnInfo(name = COL_MOBILE_NUMER) var col_mobile: String? = null,
) {
    companion object {
        const val TABLE_CUSTOMER = "Customers"
        const val COL_BRANDNAME = "CustomersName"
        const val COL_ID = "CustomersId"
        const val COL_REMARKS = "Remarks"
        const val COL_IMAGE = "CustomersImage"
        const val COL_CITY = "CustomersCity"
        const val COL_COUNTRY = "CustomersCountry"
        const val COL_ADDRESS = "CustomersAddress"
        const val COL_LAT = "CustomersLat"
        const val COL_LNG = "CustomersLng"
        const val COL_PHONE_NUMER = "CustomersPhoneNumber"
        const val COL_MOBILE_NUMER = "CustomersMobileNumber"
    }

}