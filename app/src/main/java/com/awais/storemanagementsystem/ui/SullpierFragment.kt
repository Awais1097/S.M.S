package com.awais.storemanagementsystem.ui

import android.annotation.SuppressLint
import android.app.Activity
import android.content.Intent
import android.os.Bundle
import android.text.TextUtils
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Toast
import androidx.core.graphics.drawable.toBitmap
import androidx.fragment.app.Fragment
import androidx.lifecycle.ViewModelProvider
import androidx.recyclerview.widget.LinearLayoutManager
import com.awais.route.imagepicker.ImagePicker
import com.awais.storemanagementsystem.R
import com.awais.storemanagementsystem.adapter.SupplierAdapter
import com.awais.storemanagementsystem.databinding.FragmentCustomerBinding
import com.awais.storemanagementsystem.roomdb.AppDatabase
import com.awais.storemanagementsystem.roomdb.entity.SupplierEntity
import com.awais.storemanagementsystem.viewmodel.SupplierViewModel
import com.awais.storemanagementsystem.util.PDFConverter
import com.awais.storemanagementsystem.util.Utilities
import com.bumptech.glide.Glide

class SullpierFragment : Fragment() {


    private var _binding: FragmentCustomerBinding? = null

    // This property is only valid between onCreateView and onDestroyView.
    private val binding get() = _binding!!
    private var uri: String? = null
    var mItem = SupplierEntity()

    @SuppressLint("SetTextI18n")
    override fun onCreateView(
        inflater: LayoutInflater,
        container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        val galleryViewModel =
            ViewModelProvider(this)[SupplierViewModel::class.java]

        _binding = FragmentCustomerBinding.inflate(inflater, container, false)
        val root: View = binding.root
        binding.titleTextView.text = getString(R.string.add_new_supplier)
        binding.brandMv.setImageDrawable(requireContext().getDrawable(R.drawable.supplier_img_icon))
        binding.addImage.setOnClickListener {
            ImagePicker.with(this).cameraOnly().crop().start()
        }
        binding.recyclerView.layoutManager = LinearLayoutManager(requireContext())
        galleryViewModel.list.observe(viewLifecycleOwner) {
            binding.recyclerView.adapter = SupplierAdapter(it,
                onItemClick = object : SupplierAdapter.OnItemClick {

                    override fun onDelete(item: SupplierEntity) {
                        delet(item)
                        galleryViewModel.getAll()
                    }

                    override fun onClick(item: SupplierEntity) {
                        mItem = item
                        binding.brandNameEditText.setText(item.col_name)
                        binding.mobileNumberEditText.setText(item.col_mobile)
                        binding.phoneNumberEditText.setText(item.col_phone)
                        binding.countryEditText.setText(item.col_country)
                        binding.cityEditText.setText(item.col_city)
                        binding.addressEditText.setText(item.col_address)
                        binding.remarksEditText.setText(item.col_comp_name)
                        if (item.col_imge != null) {
                            Glide.with(requireContext()).load(Utilities.decode(item.col_imge!!))
                                .centerCrop()
                                .into(binding.imageView)
                        }
                        uri = item.col_imge
                    }

                    override fun onPrint(item: SupplierEntity) {
                        val pdfConverter = PDFConverter()
                        pdfConverter.createPdf(
                            requireContext(),
                            binding.recyclerView,
                            requireActivity()
                        )
                    }
                }
            )
            binding.countTv.text =
                "${requireContext().getString(R.string.all_suppliers)} (${it.size})"
        }
        binding.saveButton.setOnClickListener {
            if (TextUtils.isEmpty(binding.brandNameEditText.text)) {
                Toast.makeText(requireContext(), "Enter Name", Toast.LENGTH_SHORT).show()
                return@setOnClickListener
            }
            if (uri == null) {
                Toast.makeText(requireContext(), "Select Image", Toast.LENGTH_SHORT).show()
                return@setOnClickListener
            }
            save()
            galleryViewModel.getAll()
            binding.brandNameEditText.text = null
            uri = null
            mItem._id = null
        }
        return root
    }

    override fun onDestroyView() {
        super.onDestroyView()
        _binding = null
    }

    override fun onActivityResult(requestCode: Int, resultCode: Int, data: Intent?) {
        super.onActivityResult(requestCode, resultCode, data)
        when (resultCode) {
            Activity.RESULT_OK -> {
                val d = data?.data!!
                Glide.with(this).load(d).centerCrop()
                    .placeholder(R.drawable.brand_icon).into(binding.imageView)
                uri = Utilities.encode(binding.imageView.drawable.toBitmap())
            }
            ImagePicker.RESULT_ERROR -> {
                Toast.makeText(requireContext(), ImagePicker.getError(data), Toast.LENGTH_SHORT)
                    .show()
            }
            else -> {
                Toast.makeText(requireContext(), "Task Cancelled", Toast.LENGTH_SHORT).show()
            }
        }
    }

    private fun save() {
        try {
            mItem.col_name = binding.brandNameEditText.text.toString()
            mItem.col_mobile = binding.mobileNumberEditText.text.toString()
            mItem.col_phone = binding.phoneNumberEditText.text.toString()
            mItem.col_country = binding.countryEditText.text.toString()
            mItem.col_city = binding.cityEditText.text.toString()
            mItem.col_address = binding.addressEditText.text.toString()
            mItem.col_comp_name = binding.remarksEditText.text.toString()
            mItem.col_imge = Utilities.encode(binding.imageView.drawable.toBitmap())
            if (mItem.col_id == null) {
                mItem.col_id = "SUP-${(binding.recyclerView.adapter?.itemCount ?: 0) + 1}"
            }
            AppDatabase.get().supplierDao().insert(mItem)
            Utilities.showSnackbar(binding.root, "Supplier Saved", null, R.color.Green)
            binding.brandNameEditText.text = null
            binding.mobileNumberEditText.text = null
            binding.phoneNumberEditText.text = null
            binding.countryEditText.text = null
            binding.cityEditText.text = null
            binding.addressEditText.text = null
            binding.remarksEditText.text = null
            binding.imageView.setImageDrawable(requireContext().getDrawable(R.drawable.empty_img_icon))
        } catch (ex: Exception) {
            Utilities.showSnackbar(binding.root, "Supplier Not Saved", null, R.color.Red)
        }
    }

    private fun delet(item: SupplierEntity) {
        try {
            AppDatabase.get().supplierDao().delete(item)
            Utilities.showSnackbar(binding.root, "Supplier Deleted", null, R.color.Green)
            binding.brandNameEditText.text = null
            binding.mobileNumberEditText.text = null
            binding.phoneNumberEditText.text = null
            binding.countryEditText.text = null
            binding.cityEditText.text = null
            binding.addressEditText.text = null
            binding.remarksEditText.text = null
            binding.imageView.setImageDrawable(requireContext().getDrawable(R.drawable.empty_img_icon))
        } catch (ex: Exception) {
            Utilities.showSnackbar(binding.root, "Supplier Not Deleted", null, R.color.Red)
        }
    }

}