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
import com.awais.storemanagementsystem.adapter.CategoryListAdapter
import com.awais.storemanagementsystem.databinding.FragmentBrandBinding
import com.awais.storemanagementsystem.roomdb.AppDatabase
import com.awais.storemanagementsystem.roomdb.entity.Categoryntity
import com.awais.storemanagementsystem.util.Utilities
import com.awais.storemanagementsystem.util.Utilities.decode
import com.awais.storemanagementsystem.viewmodel.CategoryViewModel
import com.bumptech.glide.Glide

class CategoryFragment : Fragment() {

    private var _binding: FragmentBrandBinding? = null
    // This property is only valid between onCreateView and onDestroyView.
    private var uri: String? = null
    private val binding get() = _binding!!
    var mItem = Categoryntity()

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?
    ): View {
        val viewModel =
            ViewModelProvider(this)[CategoryViewModel::class.java]
        _binding = FragmentBrandBinding.inflate(inflater, container, false)
        binding.addImage.setOnClickListener {
            ImagePicker.with(this).cameraOnly().crop().start()
        }
        binding.titleTextView.text =  requireContext().getString(R.string.add_new_category)
        binding.brandNameEditText.hint = requireContext().getString(R.string.category_title)
        binding.brandMv.setImageDrawable(requireContext().getDrawable(R.drawable.caregory_img_icon))
        binding.recyclerView.layoutManager = LinearLayoutManager(requireContext())
        viewModel.list.observe(viewLifecycleOwner) {
            binding.recyclerView.adapter = CategoryListAdapter(it,
                onItemClick = object : CategoryListAdapter.OnItemClick {
                    override fun onDelete(item: Categoryntity) {
                        deleteBrand(item)
                        viewModel.getAllBrands()
                    }

                    override fun onClick(item: Categoryntity) {
                        mItem = item
                        binding.brandNameEditText.setText(item.col_name)
                        if (item.col_imge != null) {
                            Glide.with(requireContext()).load(decode(item.col_imge!!)).centerCrop()
                                .into(binding.imageView)
                        }
                        uri = item.col_imge
                    }
                }
            )
            binding.countTv.text =
                "${requireContext().getString(R.string.all_category)} (${it.size})"
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
            mItem.col_name = binding.brandNameEditText.text.toString()
            mItem.col_imge = Utilities.encode(binding.imageView.drawable.toBitmap())
            AppDatabase.get().categoryDao().insert(mItem)
            Utilities.showSnackbar(binding.root, "Category Saved", null, R.color.Green)
        } catch (ex: Exception) {
            Utilities.showSnackbar(binding.root, "Category Not Saved", null, R.color.Red)
        }
    }

    private fun deleteBrand(item: Categoryntity) {
        try {
            AppDatabase.get().categoryDao().delete(item)
            Utilities.showSnackbar(binding.root, "Category Deleted", null, R.color.Green)
        } catch (ex: Exception) {
            Utilities.showSnackbar(binding.root, "Category Not Deleted", null, R.color.Red)
        }
    }

}