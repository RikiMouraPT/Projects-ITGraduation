<?php

use App\Http\Controllers\AdminController;
use App\Http\Controllers\CategoryController;
use App\Http\Controllers\LevelController;
use App\Http\Controllers\PriorityController;
use App\Http\Controllers\TicketController;
use App\Http\Controllers\HomeController;
use App\Models\Category;
use App\Models\Priority;
use Illuminate\Support\Facades\Route;
use Illuminate\Support\Facades\Auth;

Route::get('/', [TicketController::class, 'index'])->name('welcome');

// Admin
Route::get('/admin', [AdminController::class, 'index'])->name('admin.index')->middleware('auth');
Route::prefix('admin')->middleware('auth')->group(function () {
    Route::resource('category', CategoryController::class)->names('admin.category');
    Route::resource('level', LevelController::class)->names('admin.level');
    Route::resource('priority', PriorityController::class)->names('admin.priority');
});

Route::resource('ticket', TicketController::class)->names('ticket');

Auth::routes();

Route::get('/home', [HomeController::class, 'index'])->name('home');
