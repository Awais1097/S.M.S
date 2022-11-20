package com.awais.storemanagementsystem.roomdb.deo

import androidx.room.*
import androidx.room.OnConflictStrategy.Companion.IGNORE
import com.awais.storemanagementsystem.roomdb.entity.StockOutEntity

@Dao
interface StockOutDao {

    @Insert(entity = StockOutEntity::class, onConflict = OnConflictStrategy.REPLACE)
    fun insert(user: StockOutEntity?)

    @Query("DELETE FROM StockOut WHERE _id =:Id")
    fun delete(Id: Int)

    @Update
    fun updateUsers(vararg users: StockOutEntity)

    @Delete
    fun delete(user: StockOutEntity)

    @Query("DELETE FROM StockOut")
    fun deleteAll()

    @Query("SELECT * FROM StockOut order by _id")
    fun getAll(): List<StockOutEntity>

    @Query("SELECT * FROM StockOut WHERE _id = :pid")
    fun getById(pid: Int): StockOutEntity

    @Insert(entity = StockOutEntity::class, onConflict = OnConflictStrategy.REPLACE)
    fun insertAll(users: List<StockOutEntity>)

}