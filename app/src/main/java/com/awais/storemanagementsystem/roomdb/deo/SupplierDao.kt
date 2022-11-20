package com.awais.storemanagementsystem.roomdb.deo

import androidx.room.*
import androidx.room.OnConflictStrategy.Companion.IGNORE
import com.awais.storemanagementsystem.roomdb.entity.SupplierEntity

@Dao
interface SupplierDao {

    @Insert(entity = SupplierEntity::class, onConflict = IGNORE)
    fun insert(user: SupplierEntity?)

    @Query("DELETE FROM Suppliers WHERE SupplierId =:Id")
    fun delete(Id: Int)

    @Update
    fun updateUsers(vararg users: SupplierEntity)

    @Delete
    fun delete(user: SupplierEntity)

    @Query("DELETE FROM Suppliers")
    fun deleteAll()

    @Query("SELECT * FROM Suppliers order by SupplierId")
    fun getAll(): List<SupplierEntity>

    @Query("SELECT * FROM Suppliers WHERE SupplierId = :pid")
    fun getById(pid: Int): SupplierEntity

    @Insert(entity = SupplierEntity::class, onConflict = IGNORE)
    fun insertAll(users: List<SupplierEntity>)

    @Query("SELECT * FROM Suppliers WHERE SupplierId = :pid")
    fun getByCompanyId(pid: Int): List<SupplierEntity>

}