package com.awais.storemanagementsystem.ui

import android.annotation.SuppressLint
import android.app.DatePickerDialog
import android.os.Bundle
import android.text.TextUtils
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ArrayAdapter
import android.widget.Toast
import androidx.fragment.app.Fragment
import androidx.lifecycle.ViewModelProvider
import androidx.recyclerview.widget.LinearLayoutManager
import com.awais.storemanagementsystem.R
import com.awais.storemanagementsystem.adapter.StockInListAdapter
import com.awais.storemanagementsystem.databinding.FragmentStockBinding
import com.awais.storemanagementsystem.roomdb.AppDatabase
import com.awais.storemanagementsystem.roomdb.entity.ProductEntity
import com.awais.storemanagementsystem.roomdb.entity.StockInEntity
import com.awais.storemanagementsystem.roomdb.entity.SupplierEntity
import com.awais.storemanagementsystem.util.Utilities
import com.awais.storemanagementsystem.viewmodel.StockViewModel
import java.text.SimpleDateFormat
import java.util.*

class AddStockFragment : Fragment() {

    private var _binding: FragmentStockBinding? = null
    // This property is only valid between onCreateView and onDestroyView.
    private val binding get() = _binding!!
    var mItem = StockInEntity()
    private var productNames = ArrayList<String>()
    private var supplierNames = ArrayList<String>()
    private var producstList: List<ProductEntity> = ArrayList()
    private var sullpierList: List<SupplierEntity> = ArrayList()

    @SuppressLint("SetTextI18n")
    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?
    ): View {
        val galleryViewModel =
            ViewModelProvider(this)[StockViewModel::class.java]

        _binding = FragmentStockBinding.inflate(inflater, container, false)
        val root: View = binding.root
        val calender = Calendar.getInstance()
        binding.dateEditText.setText(
            SimpleDateFormat("EEEE, dd MMM, yyyy").format(calender.time)
                .toString()
        )
        binding.recyclerView.layoutManager = LinearLayoutManager(requireContext())
        galleryViewModel.list.observe(viewLifecycleOwner) {
            binding.recyclerView.adapter = StockInListAdapter(it,
                onItemClick = object : StockInListAdapter.OnItemClick {

                    override fun onDelete(item: StockInEntity) {
                        delet(item)
                        galleryViewModel.getAll()
                        galleryViewModel.getAllProducts()
                    }

                    override fun onClick(item: StockInEntity) {
                        mItem = item
                        binding.productEditText.setText(item.col_productName)
                        binding.supplierEditText.setText(item.col_supplierName)
                        binding.dateEditText.setText(item.col_in_date)
                        binding.qtyEditText.setText(item.col_qty.toString())
                        binding.productEditText.setText(item.col_unit_cost.toString())
                        binding.remarksEditText.setText(item.col_remarks)
                    }

                }
            )
            binding.countTv.text =
                "${requireContext().getString(R.string.all_stock)} (${it.size})"
        }
        binding.saveButton.setOnClickListener {
            if (TextUtils.isEmpty(binding.productEditText.text)) {
                Toast.makeText(requireContext(), "Enter Name", Toast.LENGTH_SHORT).show()
                return@setOnClickListener
            }
            save()
            galleryViewModel.getAll()
            mItem._id = null
        }
        binding.dateEditText.setOnClickListener {
            showDateDialog()
        }
        galleryViewModel.list_pro.observe(viewLifecycleOwner) { list ->
            productNames.clear()
            list?.forEach {
                productNames.add(it._id.toString() + " - " + it.col_productname)
            }
            producstList = list ?: emptyList()
            val adpater =
                ArrayAdapter(requireContext(), R.layout.text_item_layout, R.id.text1, productNames)
            binding.productEditText.threshold = 1
            binding.productEditText.setAdapter(adpater)
        }
        galleryViewModel.list_sup.observe(viewLifecycleOwner) { list ->
            supplierNames.clear()
            list?.forEach {
                supplierNames.add(it._id.toString() + " - " + it.col_name)
            }
            sullpierList = list ?: emptyList()
            val adpater =
                ArrayAdapter(requireContext(), R.layout.text_item_layout, R.id.text1, supplierNames)
            binding.supplierEditText.threshold = 1
            binding.supplierEditText.setAdapter(adpater)
        }
        return root
    }

    override fun onDestroyView() {
        super.onDestroyView()
        _binding = null
    }

    private fun save() {
        try {
            mItem.col_productName = binding.productEditText.text.toString()
            mItem.col_supplierName = binding.supplierEditText.text.toString()
            mItem.col_in_date = binding.dateEditText.text.toString()
            mItem.col_qty = try {
                binding.qtyEditText.text.toString().toInt()
            } catch (ex: Exception) {
                0
            }
            mItem.col_unit_cost = try {
                binding.priceEditText.text.toString().toDouble()
            } catch (ex: Exception) {
                0.0
            }
            val products = producstList.find {
                it._id.toString() + " - " + it.col_productname == binding.productEditText.text.toString()
            }
            if (products != null) {
                mItem.col_productId = products._id.toString()
                mItem.col_productName = products.col_productname
                mItem.col_img = products.col_img
            }
            val supplier = sullpierList.find {
                it._id.toString() + " - " + it.col_name == binding.productEditText.text.toString()
            }
            if (supplier != null) {
                mItem.col_supplierId = supplier._id.toString()
                mItem.col_supplierName = supplier.col_name
            }
            mItem.col_remarks = binding.remarksEditText.text.toString()
            AppDatabase.get().stcockInDao().insert(mItem)
            Utilities.showSnackbar(binding.root, "Stock Saved", null, R.color.Green)
            binding.productEditText.text = null
            binding.supplierEditText.text = null
            binding.dateEditText.text = null
            binding.qtyEditText.text = null
            binding.priceEditText.text = null
            binding.remarksEditText.text = null
        } catch (ex: Exception) {
            Utilities.showSnackbar(binding.root, "Stock Not Saved", null, R.color.Red)
        }
    }

    private fun delet(item: StockInEntity) {
        try {
            AppDatabase.get().stcockInDao().delete(item)
            Utilities.showSnackbar(binding.root, "Stock Deleted", null, R.color.Green)
            binding.productEditText.text = null
            binding.supplierEditText.text = null
            binding.dateEditText.text = null
            binding.qtyEditText.text = null
            binding.priceEditText.text = null
            binding.remarksEditText.text = null
        } catch (ex: Exception) {
            Utilities.showSnackbar(binding.root, "Stock Not Deleted", null, R.color.Red)
        }
    }

    private fun showDateDialog() {
        val dialog = DatePickerDialog(requireContext())
        dialog.setOnDateSetListener { _, year, month, dayOfMonth ->
            dialog.dismiss()
            val calender = Calendar.getInstance()
            calender.set(year, month, dayOfMonth)
            binding.dateEditText.setText(
                SimpleDateFormat("EEEE, dd MMM, yyyy").format(calender.time)
                    .toString()
            )
        }
        dialog.show()
    }


}