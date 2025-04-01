<?php

use App\Http\Controllers\AdminController;
use App\Http\Controllers\CategoryController;
use App\Models\Category;
use Illuminate\Support\Facades\Route;

Route::get('/', function () {
    return view('welcome');
})->name('welcome');

//Route::get('/admin', 'AdminController@index')
//  ->name('admin.index');
Route::get('/admin', [AdminController::class, 'index'])->name('admin.index');

Route::get('/admin/category', [CategoryController::class, 'index'])->name('admin.category.index');
Route::get('/admin/category/create', [CategoryController::class, 'create'])->name('admin.category.create');
Route::post('/admin/category/store', [CategoryController::class, 'store'])->name('admin.category.store');
Route::get('/admin/category/show/{category}', [CategoryController::class, 'show'])->name('admin.category.show');
Route::get('/admin/category/edit/{category}', [CategoryController::class, 'edit'])->name('admin.category.edit');
Route::put('/admin/category/update/{category}', [CategoryController::class, 'update'])->name('admin.category.update');
Route::delete('/admin/category/delete/{category}', [CategoryController::class, 'destroy'])->name('admin.category.destroy');