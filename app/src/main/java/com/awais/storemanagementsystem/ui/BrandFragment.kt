package com.awais.storemanagementsystem.ui

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
import com.awais.storemanagementsystem.adapter.BrandListAdapter
import com.awais.storemanagementsystem.databinding.FragmentBrandBinding
import com.awais.storemanagementsystem.roomdb.AppDatabase
import com.awais.storemanagementsystem.roomdb.entity.BrandEntity
import com.awais.storemanagementsystem.util.Utilities
import com.awais.storemanagementsystem.util.Utilities.decode
import com.awais.storemanagementsystem.viewmodel.ProductsViewModel
import com.bumptech.glide.Glide

class BrandFragment : Fragment() {

    private var _binding: FragmentBrandBinding? = null
    // This property is only valid between onCreateView and onDestroyView.
    private var uri: String? = null
    private val binding get() = _binding!!
    var mItem = BrandEntity()

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?
    ): View {
        val viewModel =
            ViewModelProvider(this)[ProductsViewModel::class.java]
        _binding = FragmentBrandBinding.inflate(inflater, container, false)
        binding.addImage.setOnClickListener {
            ImagePicker.with(this).cameraOnly().crop().start()
        }
        binding.recyclerView.layoutManager = LinearLayoutManager(requireContext())
        viewModel.getAllBrands()
        viewModel.list_brand.observe(viewLifecycleOwner) {
            binding.recyclerView.adapter = BrandListAdapter(it,
                onItemClick = object : BrandListAdapter.OnItemClick {
                    override fun onDelete(item: BrandEntity) {
                        deleteBrand(item)
                        viewModel.getAllBrands()
                    }

                    override fun onClick(item: BrandEntity) {
                        mItem = item
                        binding.brandNameEditText.setText(item.col_branchname)
                        if (item.col_imge != null) {
                            Glide.with(requireContext()).load(decode(item.col_imge!!)).centerCrop()
                                .into(binding.imageView)
                        }
                        uri = item.col_imge
                    }
                }
            )
            binding.countTv.text =
                "${requireContext().getString(R.string.all_brands)} (${it.size})"
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
            viewModel.getAllBrands()
            binding.brandNameEditText.text = null
            uri = null
            binding.imageView.setImageDrawable(requireContext().getDrawable(R.drawable.empty_img_icon))
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
            mItem.col_branchname = binding.brandNameEditText.text.toString()
            mItem.col_imge = Utilities.encode(binding.imageView.drawable.toBitmap())
            AppDatabase.get().brandsDao().insert(mItem)
            Utilities.showSnackbar(binding.root, "Brand Saved", null, R.color.Green)
        } catch (ex: Exception) {
            Utilities.showSnackbar(binding.root, "Brand Not Saved", null, R.color.Red)
        }
    }

    private fun deleteBrand(item: BrandEntity) {
        try {
            AppDatabase.get().brandsDao().delete(item)
            Utilities.showSnackbar(binding.root, "Brand Deleted", null, R.color.Green)
        } catch (ex: Exception) {
            Utilities.showSnackbar(binding.root, "Brand Not Deleted", null, R.color.Red)
        }
    }

}