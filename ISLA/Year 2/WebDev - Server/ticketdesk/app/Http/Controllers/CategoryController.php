<?php

namespace App\Http\Controllers;

use App\Models\Category;
use App\Http\Requests\StoreCategoryRequest;
use App\Http\Requests\UpdateCategoryRequest;
use Illuminate\Http\Request;

class CategoryController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        $categories = Category::get();

        return view('admin.category.index', [
            'categories' => $categories
        ]);
    }

    /**
     * Show the form for creating a new resource.
     */
    public function create()
    {
        return view('admin.category.create');
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(Request $request)
    {
        $category = new Category();
        $category->name = $request->name;
        $category->status = $request->status;
        $category->save();
        
        return redirect()->route('admin.category.index')->with('success', 'Category saved successfully!');
    }

    /**
     * Display the specified resource.
     */
    public function show(string $id)
    {
        $category = Category::find($id);

        return view('admin.category.show',[
            'category' => $category
        ]);
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(string $id)
    {
        $category = Category::find($id);

        return view('admin.category.edit', [
            'category' => $category
        ]);
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(Request $request, string $id)
    {
        if (Category::where('id', $id)->exists()) {
            
            $category = Category::findOrFail($id);
            
            $category->name = $request->name;
            $category->status = $request->status;
            
            $category->save();

            return redirect()->route('admin.category.index')->with('sucess', 'Category updated successfully!');
        } else {
            return redirect()->route('admin.category.index')->with('error', 'Category not found.');
        }

    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(string $id)
    {
        if (Category::where('id', $id)->exists()) {
            $category = Category::findOrFail($id);
            $category->delete();

            return redirect()->route('admin.category.index')->with('success', 'Category deleted successfully!');
        } else {
            return redirect()->route('admin.category.index')->with('error', 'Category not found.');
        }
    }
}
