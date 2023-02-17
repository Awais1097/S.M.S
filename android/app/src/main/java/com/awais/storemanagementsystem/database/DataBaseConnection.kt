package com.awais.storemanagementsystem.database

import android.util.Log
import kotlinx.coroutines.*
import java.sql.Connection
import java.sql.DriverManager
import java.sql.SQLException
import kotlin.coroutines.CoroutineContext

abstract class DataBaseConnection : CoroutineScope {

    private val job: Job = Job()
    override val coroutineContext: CoroutineContext
        get() = Dispatchers.Main + job


    fun calcel() {
        job.cancel()
    }

    private suspend fun doInBackground(ip: ServerData): Connection? = withContext(Dispatchers.IO) {
        return@withContext createConnection(ip)
    }

    fun execute(ip: ServerData) = launch {
        try {
            val result = doInBackground(ip)
            if (result != null) {
                Log.e("Sql ", result.metaData.userName)
                onPostExecute(result)
            } else {
                onError("Connect is Null")
            }
        } catch (e: Exception) {
            Log.e("Sql Error", "$e")
            onError(e.toString())
        }
    }

    protected abstract fun onPostExecute(connection: Connection)
    protected abstract fun onError(connection: String)


    @Throws(ClassNotFoundException::class, SQLException::class)
    fun createConnection(ip: ServerData): Connection? {
        return createConnection(
            if (ip.type == ORACLE) DEFULT_DRIVER else DEFULT_DRIVER_SQL,
            if (ip.type == ORACLE) "${DEFULT_URL}${ip.ip}:${PORT}:${ip.database}"
            else "${DEFULT_URL_SQL}${ip.ip}:${PORT}/${ip.database}",
            ip.user,
            ip.password
        )
    }

    @Throws(ClassNotFoundException::class, SQLException::class)
    fun createConnection(
        drive: String, url: String, user: String, password: String
    ): Connection? {
        Class.forName(drive)
        return DriverManager.getConnection(url, user, password)
    }

    companion object {

        const val IP_ADDRESS = "137.59.224.65"
        const val PORT = "1521"
        const val DATABASE_NAME = "orcl"
        const val USER = "bsp"
        const val PASSWORD = "teachers"
        var ORACLE = "Oracle"
        const val SQL = "SQL Server"
        const val DEFULT_DRIVER = "oracle.jdbc.driver.OracleDriver"
        const val DEFULT_DRIVER_SQL = "net.sourceforge.jtds.jdbc.Driver"
        const val DEFULT_URL = "jdbc:oracle:thin:@"
        const val DEFULT_URL_SQL = "jdbc:jtds:sqlserver://"

        /*suspend fun getRegions(connection: Connection): ArrayList<RegionEntity> =
            withContext(Dispatchers.IO) {
                val list: ArrayList<RegionEntity> = ArrayList()
                val stream = connection.createStatement()
                val q = REGIONS + " " + UserData.getUser(App.context).id?.toInt() + ")))"
                Log.d("Query", q)
                val execute = stream.execute(q)
                if (execute) {
                    try {
                        val data = stream.resultSet
                        while (data.next()) {
                            list.add(
                                RegionEntity(
                                    _id = null,
                                    col_regioid = data.getString(1),
                                    col_regain_name = data.getString(2),
                                    col_customer_id = data.getInt(3),
                                    col_customer_name = data.getString(4)
                                )
                            )
                        }
                    } catch (e: Exception) {
                        Log.e("Error", "$e")
                    }
                }
                stream.close()
                return@withContext list
            }

        suspend fun getCustomerSchdule(
            connection: Connection,
            id: Int
        ): ArrayList<CustomerSchedule> =
            withContext(Dispatchers.IO)
            {
                val list: ArrayList<CustomerSchedule> = ArrayList()
                val stream = connection.createStatement()
                Log.d("Query", CUSTOMER_SCHDULE + id)
                val execute = stream.execute(CUSTOMER_SCHDULE + id)
                if (execute) {
                    val data = stream.resultSet
                    while (data.next()) {
                        list.add(
                            CustomerSchedule(null, data.getInt(1), data.getInt(2))
                        )
                    }
                }
                stream.close()
                return@withContext list
            }

        suspend fun getCustomer(connection: Connection): ArrayList<Customer> =
            withContext(Dispatchers.IO)
            {
                val list: ArrayList<Customer> = ArrayList()
                val stream = connection.createStatement()
                val user = UserData.getUser(App.context)
                val q = "$CUSTOMER ${user.id?.toInt()})))group by regionid)"
                Log.d("Query", q)
                val execute = stream.execute(q)
                if (execute) {
                    val data = stream.resultSet
                    while (data.next()) {
                        list.add(
                            Customer(
                                null,
                                data.getString(1),
                                data.getString(2),
                                data.getString(3),
                                data.getString(4),
                                data.getString(5),
                                data.getString(6),
                                data.getString(7),
                                data.getString(8),
                                data.getString(9),
                                data.getString(10),
                                data.getString(11),
                                data.getString(12),
                                data.getString(13),
                                data.getString(14),
                                data.getString(15),
                                data.getString(16),
                                data.getString(17),
                                data.getString(18)
                            )
                        )
                    }
                }
                stream.close()
                return@withContext list
            }

        suspend fun getCustomerLocations(
            connection: Connection,
            id: String
        ): ArrayList<LocationsEntity> =
            withContext(Dispatchers.IO)
            {
                val list: ArrayList<LocationsEntity> = ArrayList()
                val stream = connection.createStatement()
                try {
                    val q = "select * from CUSTOMERLOCATIONS where customer_id = $id"
                    Log.d("Query", q)
                    val execute = stream.execute(q)
                    if (execute) {
                        val data = stream.resultSet
                        while (data.next()) {
                            list.add(
                                LocationsEntity(
                                    _id = null,
                                    customerid = data.getString(1),
                                    locationid = data.getString(2),
                                    col_name = data.getString(3),
                                    col_address = data.getString(4),
                                    latitude = data.getString(5),
                                    longitude = data.getString(6),
                                    col_status = data.getString(7),
                                    col_date = try {
                                        data.getString(8)
                                    } catch (ex: Exception) {
                                        "N/A"
                                    },
                                )
                            )
                        }
                    }
                } catch (ex: Exception) {
                    ex.printStackTrace()
                }
                stream.close()
                return@withContext list
            }

        suspend fun getSchdule(connection: Connection): ArrayList<Schedule> =
            withContext(Dispatchers.IO)
            {
                val list: ArrayList<Schedule> = ArrayList()
                val stream = connection.createStatement()
                val q = SCHDULE + " " + UserData.getUser(App.context).id?.toInt()
                Log.d("Query", q)
                val execute =
                    stream.execute(q)
                if (execute) {
                    val data = stream.resultSet
                    while (data.next()) {
                        list.add(
                            Schedule(
                                null,
                                data.getInt(1),
                                data.getInt(2),
                                data.getInt(3),
                                data.getString(4),
                                data.getString(5),
                                data.getString(6)
                            )
                        )
                    }
                }
                stream.close()
                return@withContext list
            }


        suspend fun getProducts(connection: Connection): ArrayList<ProductEntity> =
            withContext(Dispatchers.IO)
            {
                val list: ArrayList<ProductEntity> = ArrayList()
                val stream = connection.createStatement()
                Log.d("Query", PRODUCTS + " " + UserData.getUser(App.context).id?.toInt() + " ")
                val execute =
                    stream.execute(PRODUCTS + " " + UserData.getUser(App.context).id?.toInt() + " ")
                if (execute) {
                    val data = stream.resultSet
                    while (data.next()) {
                        list.add(
                            ProductEntity(
                                null,
                                data.getInt(1),
                                data.getInt(2),
                                data.getInt(3),
                                data.getString(4),
                                data.getString(5),
                                data.getString(6) ?: "N/A",
                                data.getString(7) ?: "N/A",
                                data.getDouble(8),
                                data.getDouble(9),
                                data.getString(10),
                                data.getString(11) ?: "N/A",
                                data.getString(12) ?: "N/A",
                                try {
                                    data.getString(13) ?: "0"
                                } catch (ex: Exception) {
                                    "0"
                                },
                                data.getString(14) ?: "N/A"
                            )
                        )
                    }
                }
                stream.close()
                return@withContext list
            }

        @SuppressLint("NewApi", "SimpleDateFormat")
        suspend fun saveOrder(connection: Connection, productSale: ProductSale): String =
            withContext(Dispatchers.IO) {
                try {
                    val date = try {
                        SimpleDateFormat("yyyy/MM/dd HH:mm:ss").parse(productSale.col_bookingdate)
                    } catch (ex: Exception) {
                        Date()
                    }
                    val currentData = SimpleDateFormat("HHmmss").format(Date().time)
                    val id =
                        productSale.col_porductid + productSale.col_userid.toString() + productSale.col_customerid + currentData
                    val stream = connection.prepareStatement(INSERTORDERS)
                    stream.setLong(1, id.toLong())
                    stream.setTime(2, java.sql.Time(date?.time ?: Date().time))
                    stream.setTime(3, java.sql.Time(Date().time))
                    stream.setInt(4, productSale.col_customerid?.toInt() ?: 0)
                    stream.setString(5, productSale.col_porductid ?: "")
                    stream.setInt(6, productSale.col_qty ?: 0)
                    stream.setString(7, "U")
                    stream.setString(8, productSale.col_userid?.toString() ?: "")
                    stream.setString(9, productSale.latitude ?: "")
                    stream.setString(10, productSale.longitude ?: "")
                    stream.setString(11, "C")
                    stream.setString(12, productSale.col_clouduploadstatus ?: "")
                    stream.executeUpdate()
                    Log.e("Saved Order", "$id")
                    return@withContext "Uploaded"
                } catch (e: Exception) {
                    Log.e("Saved Not Order", "$e")
                    return@withContext "Try Again , Please \n Error:$e"
                }
            }

        @SuppressLint("NewApi", "SimpleDateFormat")
        suspend fun saveCustomerLocation(connection: Connection, customer: LocationsEntity?): String =
            withContext(Dispatchers.IO) {
                try {
                    val update= updateOrder(connection,customer)
                    if(update){
                        val stream = connection.prepareStatement(UPDATELOCATIONS)
                        stream.setInt(1, 0)
                        stream.setString(2, customer?.locationid)
                        stream.executeUpdate()
                        Log.e("Update Location", "${customer?.locationid}")
                    }else{
                        val stream = connection.prepareStatement(INSERTLOCATIONS)
                        stream.setInt(1, customer?.customerid?.toInt() ?: 0)
                        stream.setString(2, customer?.locationid)
                        stream.setString(3, customer?.col_name)
                        stream.setString(4, customer?.col_address)
                        stream.setString(5, customer?.latitude)
                        stream.setString(6, customer?.longitude)
                        stream.setInt(7, customer?.col_status?.toInt() ?: 0)
                        stream.setTime(8, java.sql.Time(Date().time))
                        stream.setString(9, UserData.getUser(App.context).id)
                        stream.executeUpdate()
                        Log.e("Saved Location", "${customer?.locationid}")
                    }
                    return@withContext "Uploaded"
                } catch (e: Exception) {
                    return@withContext "Tyr Again , Please \n Error:$e"
                }
            }

        suspend fun getRunAnyCommand(connection: Connection, query: String): String =
            withContext(Dispatchers.IO) {
                var result: String
                try {
                    val stream = connection.createStatement()
                    Log.d("Query", query)
                    val exe = stream.execute(query)
                    result = if (exe) {
                        (stream.resultSet.fetchDirection / 1000).toString()
                    } else {
                        "error"
                    }
                    stream.close()
                } catch (ex: Exception) {
                    Log.d("Query Error ", ex.toString())
                    result = "error"
                }
                return@withContext result
            }

        fun updateOrder(connection: Connection,customer: LocationsEntity?) : Boolean{
            var result = false
            val stream = connection.createStatement()
            try {
                val q = "select * from CUSTOMERLOCATIONS where location_id = ${customer?.locationid}"
                Log.d("Query", q)
                val execute = stream.execute(q)
                if (execute) {
                    val data = stream.resultSet
                    result = data.next()
                }
            } catch (ex: Exception) {
                ex.printStackTrace()
                result = false
            }
            stream.close()
            return result
        }*/
    }



}