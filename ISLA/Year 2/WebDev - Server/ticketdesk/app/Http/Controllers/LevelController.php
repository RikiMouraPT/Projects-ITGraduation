<?php

namespace App\Http\Controllers;

use App\Models\Level;
use App\Http\Requests\StoreLevelRequest;
use App\Http\Requests\UpdateLevelRequest;
use Illuminate\Http\Request;

class LevelController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        $levels = Level::get();

        return view('admin.level.index', [
            'levels' => $levels
        ]);
    }

    /**
     * Show the form for creating a new resource.
     */
    public function create()
    {
        return view('admin.level.create');
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(Request $request)
    {
        $request->validate([
            'name' => 'required|string|max:255|min:3|unique:levels',
            'status' => 'required|in:active,inactive',
        ]);

        $level = new Level();
        $level->name = $request->name;
        $level->status = $request->status;
        $level->save();
        
        return redirect()->route('admin.level.index')->with('success', 'Level saved successfully!');
    }

    /**
     * Display the specified resource.
     */
    public function show(string $id)
    {
        $level = level::find($id);

        return view('admin.level.show',[
            'level' => $level
        ]);
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(string $id)
    {
        $level = Level::find($id);

        return view('admin.level.edit', [
            'level' => $level
        ]);
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(Request $request, string $id)
    {
        $request->validate([
            'name' => 'required|string|max:255|min:3|unique:levels,name,' . $id,
            'status' => 'required|in:active,inactive',
        ]);

        if (Level::where('id', $id)->exists()) {
            
            $level = Level::findOrFail($id);
            
            $level->name = $request->name;
            $level->status = $request->status;
            
            $level->save();

            return redirect()->route('admin.level.index')->with('sucess', 'level updated successfully!');
        } else {
            return redirect()->route('admin.level.index')->with('error', 'level not found.');
        }

    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(string $id)
    {
        if (Level::where('id', $id)->exists()) {
            $level = Level::findOrFail($id);
            $level->delete();

            return redirect()->route('admin.level.index')->with('success', 'level deleted successfully!');
        } else {
            return redirect()->route('admin.level.index')->with('error', 'level not found.');
        }
    }
}
