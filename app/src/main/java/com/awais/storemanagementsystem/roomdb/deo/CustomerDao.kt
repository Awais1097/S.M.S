package com.awais.storemanagementsystem.roomdb.deo

import androidx.room.*
import androidx.room.OnConflictStrategy.Companion.IGNORE
import com.awais.storemanagementsystem.roomdb.entity.CustomerEntity

@Dao
interface CustomerDao {

    @Insert(entity = CustomerEntity::class, onConflict = IGNORE)
    fun insert(user: CustomerEntity?)

    @Query("DELETE FROM Customers WHERE CustomersId =:Id")
    fun delete(Id: Int)

    @Update
    fun updateUsers(vararg users: CustomerEntity)

    @Delete
    fun delete(user: CustomerEntity)

    @Query("DELETE FROM Customers")
    fun deleteAll()

    @Query("SELECT * FROM Customers order by CustomersId")
    fun getAll(): List<CustomerEntity>

    @Query("SELECT * FROM Customers WHERE CustomersId = :pid")
    fun getById(pid: Int): CustomerEntity

    @Insert(entity = CustomerEntity::class, onConflict = IGNORE)
    fun insertAll(users: List<CustomerEntity>)

   /* @Query("SELECT * FROM Customers WHERE CustomersCompId = :pid")
    fun getByCompanyId(pid: Int): List<CustomerEntity>*/

}