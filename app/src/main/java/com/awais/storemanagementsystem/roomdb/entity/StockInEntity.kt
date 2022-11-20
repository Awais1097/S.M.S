package com.awais.storemanagementsystem.roomdb.entity

import androidx.room.ColumnInfo
import androidx.room.Entity
import androidx.room.PrimaryKey
import com.awais.storemanagementsystem.roomdb.entity.StockInEntity.Companion.TABLE_STOCKIN

@Entity(tableName = TABLE_STOCKIN)
class StockInEntity(
    @PrimaryKey(autoGenerate = true) var _id: Int? = null,
    @ColumnInfo(name = COL_INDATE) var col_in_date: String? = null,
    @ColumnInfo(name = COL_QTY) var col_qty: Int? = null,
    @ColumnInfo(name = COL_UNITCOST) var col_unit_cost: Double? = null,
    @ColumnInfo(name = COL_SUPPLIER_ID) var col_supplierId: String? = null,
    @ColumnInfo(name = COL_SUPPLIER_NAME) var col_supplierName: String? = null,
    @ColumnInfo(name = COL_PRODUCT_ID) var col_productId: String? = null,
    @ColumnInfo(name = COL_PRODUCT_NAME) var col_productName: String? = null,
    @ColumnInfo(name = COL_REMARKS) var col_remarks: String? = null,
) {
    companion object {
        const val TABLE_STOCKIN = "StockIn"
        const val COL_INDATE = "inDate"
        const val COL_QTY = "inQty"
        const val COL_UNITCOST = "unitCost"
        const val COL_SUPPLIER_ID = "supplierId"
        const val COL_SUPPLIER_NAME = "supplierName"
        const val COL_PRODUCT_ID = "productId"
        const val COL_PRODUCT_NAME = "productName"
        const val COL_REMARKS = "remarks"
    }

}