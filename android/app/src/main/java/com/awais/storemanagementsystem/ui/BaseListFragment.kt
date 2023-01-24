package com.awais.storemanagementsystem.ui

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.recyclerview.widget.LinearLayoutManager
import com.awais.storemanagementsystem.databinding.BaseFragmentListBinding

/**
 * A simple [Fragment] subclass.
 * Activities that contain this fragment must implement the
 * create an instance of this fragment.
 */
abstract class BaseListFragment : Fragment() {

    private var _binding: BaseFragmentListBinding? = null
    val binding get() = _binding!!

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = BaseFragmentListBinding.inflate(inflater, container, false)
        binding.empty.visibility = View.GONE
        setEnableSwipe(false)
        binding.fab.setOnClickListener { onFabClicked() }
        updateFabUi()
        binding.list.layoutManager = LinearLayoutManager(context)
        setAdaptor()
        loadData()
        return _binding?.root
    }

    private fun updateFabUi() {
        if (showFab()) binding.fab.show()
    }

    override fun onDestroyView() {
        super.onDestroyView()
        _binding = null
    }

    open fun setAdaptor() {}
    protected abstract fun loadData()
    protected fun onFabClicked() {}
    protected abstract fun showFab(): Boolean

    open fun setEnableSwipe(enable: Boolean) {
        binding.swipe.isEnabled = enable
    }

}