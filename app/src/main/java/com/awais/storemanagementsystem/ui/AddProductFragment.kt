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
import com.awais.storemanagementsystem.adapter.ProductsListAdapter
import com.awais.storemanagementsystem.databinding.FragmentAddProductsBinding
import com.awais.storemanagementsystem.roomdb.AppDatabase
import com.awais.storemanagementsystem.roomdb.entity.ProductEntity
import com.awais.storemanagementsystem.util.Utilities
import com.awais.storemanagementsystem.util.Utilities.decode
import com.awais.storemanagementsystem.viewmodel.ProductsViewModel
import com.bumptech.glide.Glide

class AddProductFragment : Fragment() {

    private var _binding: FragmentAddProductsBinding? = null
    private var uri: String? = null
    private val binding get() = _binding!!
    var mItem = ProductEntity()

    @SuppressLint("SetTextI18n", "UseCompatLoadingForDrawables")
    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?
    ): View {
        val viewModel =
            ViewModelProvider(this)[ProductsViewModel::class.java]
        _binding = FragmentAddProductsBinding.inflate(inflater, container, false)
        binding.addImage.setOnClickListener {
            ImagePicker.with(this).cameraOnly().crop().start()
        }
        binding.recyclerView.layoutManager = LinearLayoutManager(requireContext())

        viewModel.list.observe(viewLifecycleOwner) {
            binding.recyclerView.adapter = ProductsListAdapter(it,
                onItemClick = object : ProductsListAdapter.OnItemClick {

                    override fun onDelete(item: ProductEntity) {
                        deleteBrand(item)
                        viewModel.getAll()
                    }

                    override fun onClick(item: ProductEntity) {
                        mItem = item
                        binding.brandNameEditText.setText(item.col_productname)
                        if (item.col_img != null) {
                            Glide.with(requireContext()).load(decode(item.col_img!!)).centerCrop()
                                .into(binding.imageView)
                        }
                        uri = item.col_img
                    }
                }
            )
            binding.countTv.text =
                "${requireContext().getString(R.string.all_products)} (${it.size})"
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
            saveBrand()
            viewModel.getAll()
            binding.brandNameEditText.text = null
            uri = null
            binding.imageView.setImageDrawable(null)
            mItem._id = null
        }
        return binding.root
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
                uri =  Utilities.encode(binding.imageView.drawable.toBitmap())
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

    private fun saveBrand() {
        try {
            mItem.col_productname = binding.brandNameEditText.text.toString()
            mItem.col_img = Utilities.encode(binding.imageView.drawable.toBitmap())
            if(mItem.col_productid == null){
                mItem.col_productid = "PRO-${(binding.recyclerView.adapter?.itemCount ?: 0) + 1}"
            }
            AppDatabase.get().productsDao().insert(mItem)
            Utilities.showSnackbar(binding.root, "Product Saved", null, R.color.Green)
        } catch (ex: Exception) {
            Utilities.showSnackbar(binding.root, "Product Not Saved", null, R.color.Red)
        }
    }

    private fun deleteBrand(item: ProductEntity) {
        try {
            AppDatabase.get().productsDao().delete(item)
            Utilities.showSnackbar(binding.root, "Product Deleted", null, R.color.Green)
        } catch (ex: Exception) {
            Utilities.showSnackbar(binding.root, "Product Not Deleted", null, R.color.Red)
        }
    }

}