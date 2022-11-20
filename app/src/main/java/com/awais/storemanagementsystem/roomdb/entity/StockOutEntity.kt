package com.awais.storemanagementsystem.roomdb.entity

import androidx.room.ColumnInfo
import androidx.room.Entity
import androidx.room.PrimaryKey
import com.awais.storemanagementsystem.roomdb.entity.StockOutEntity.Companion.TABLE_STOCKOUT

@Entity(tableName = TABLE_STOCKOUT)
class StockOutEntity(
    @PrimaryKey(autoGenerate = true) var _id: Int? = null,
    @ColumnInfo(name = COL_INDATE) var col_in_date: String? = null,
    @ColumnInfo(name = COL_QTY) var col_qty: Int? = null,
    @ColumnInfo(name = COL_STOCK_ID) var col_stcokId: Int? = null,
) {
    companion object {
        const val TABLE_STOCKOUT = "StockOut"
        const val COL_INDATE = "inDate"
        const val COL_QTY = "inQty"
        const val COL_STOCK_ID = "stcokId"
    }

}