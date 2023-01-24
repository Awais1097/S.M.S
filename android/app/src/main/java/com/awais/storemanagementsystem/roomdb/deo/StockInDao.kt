package com.awais.storemanagementsystem.roomdb.deo

import androidx.room.*
import androidx.room.OnConflictStrategy.Companion.IGNORE
import com.awais.storemanagementsystem.roomdb.entity.StockInEntity

@Dao
interface StockInDao {

    @Insert(entity = StockInEntity::class, onConflict = OnConflictStrategy.REPLACE)
    fun insert(user: StockInEntity?)

    @Query("DELETE FROM StockIn WHERE _id =:Id")
    fun delete(Id: Int)

    @Update
    fun updateUsers(vararg users: StockInEntity)

    @Delete
    fun delete(user: StockInEntity)

    @Query("DELETE FROM StockIn")
    fun deleteAll()

    @Query("SELECT * FROM StockIn order by _id")
    fun getAll(): List<StockInEntity>

    @Query("SELECT * FROM StockIn WHERE _id = :pid")
    fun getById(pid: Int): StockInEntity

    @Insert(entity = StockInEntity::class, onConflict = OnConflictStrategy.REPLACE)
    fun insertAll(users: List<StockInEntity>)

}