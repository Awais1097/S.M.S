package com.awais.storemanagementsystem.roomdb.entity

import androidx.room.ColumnInfo
import androidx.room.Entity
import androidx.room.PrimaryKey
import com.awais.storemanagementsystem.roomdb.entity.ProductEntity.Companion.TABLE_PRODUCT

@Entity(tableName = TABLE_PRODUCT)
class ProductEntity(
    @PrimaryKey(autoGenerate = true) var _id: Int? = null,
    @ColumnInfo(name = COL_PRODUCTID) var col_productid: String? = null,
    @ColumnInfo(name = COL_PRODUCTNAME) var col_productname: String? = null,
    @ColumnInfo(name = COL_UNITSIZE) var col_unitsize: String? = null,
    @ColumnInfo(name = COL_CARTONSIZE) var col_cartonsize: String? = null,
    @ColumnInfo(name = COL_UNITPRICE) var col_unitprice: Double? = null,
    @ColumnInfo(name = COL_RETAILPRICE) var col_retailprice: Double? = null,
    @ColumnInfo(name = COL_CATEGORYID) var col_categoryid: Int? = null,
    @ColumnInfo(name = COL_CATEGORYNAME) var col_categoryname: String? = null,
    @ColumnInfo(name = COL_BRANDID) var col_brandid: Int? = null,
    @ColumnInfo(name = COL_BRANDNAME) var col_brandname: String? = null,
    @ColumnInfo(name = COL_COMPID) var col_compid: String? = null,
    @ColumnInfo(name = COL_COMPNAME) var col_compname: String? = null,
    @ColumnInfo(name = COL_RACKID) var col_rackid: String? = null,
    @ColumnInfo(name = COL_RACKNAME) var col_rackname: String? = null,
    @ColumnInfo(name = COL_IMG) var col_img: String? = null,

    ) {
    companion object {
        const val TABLE_PRODUCT = "product"
        const val COL_PRODUCTID = "productid"
        const val COL_PRODUCTNAME = "productname"
        const val COL_UNITSIZE = "unitsize"
        const val COL_CARTONSIZE = "cartonsize"
        const val COL_UNITPRICE = "unitprice"
        const val COL_RETAILPRICE = "retailprice"
        const val COL_CATEGORYID = "categoryid"
        const val COL_CATEGORYNAME = "categoryname"
        const val COL_BRANDID = "brandid"
        const val COL_BRANDNAME = "brandname"
        const val COL_COMPID = "compid"
        const val COL_COMPNAME = "compname"
        const val COL_RACKID = "rackid"
        const val COL_RACKNAME = "rackname"
        const val COL_IMG = "proimg"
    }

}