package com.awais.storemanagementsystem.roomdb.deo

import androidx.room.*
import androidx.room.OnConflictStrategy.Companion.IGNORE
import com.awais.storemanagementsystem.roomdb.entity.ProductEntity

@Dao
interface ProductsDao {

    @Insert(entity = ProductEntity::class, onConflict = OnConflictStrategy.REPLACE)
    fun insert(user: ProductEntity?)

    @Query("DELETE FROM product WHERE productid =:Id")
    fun delete(Id: Int)

    @Update
    fun updateUsers(vararg users: ProductEntity)

    @Delete
    fun delete(user: ProductEntity)

    @Query("DELETE FROM product")
    fun deleteAll()

    @Query("SELECT * FROM product order by productname")
    fun getAll(): List<ProductEntity>

    @Query("SELECT * FROM product WHERE productid = :pid")
    fun getById(pid: Int): ProductEntity

    @Insert(entity = ProductEntity::class, onConflict = OnConflictStrategy.REPLACE)
    fun insertAll(users: List<ProductEntity>)

    @Query("SELECT * FROM product WHERE productname = :pid")
    fun getByName(pid: String): ProductEntity

}