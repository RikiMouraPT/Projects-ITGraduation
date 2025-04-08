<?php

namespace App\Http\Controllers;

use App\Models\Priority;
use App\Http\Requests\StorePriorityRequest;
use App\Http\Requests\UpdatePriorityRequest;
use Illuminate\Http\Request;

class PriorityController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        $priorities = Priority::get();

        return view('admin.priority.index', [
            'priorities' => $priorities
        ]);
    }

    /**
     * Show the form for creating a new resource.
     */
    public function create()
    {
        return view('admin.priority.create');
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(Request $request)
    {
        $request->validate([
            'name' => 'required|string|max:255|min:3|unique:priorities',
            'status' => 'required|in:active,inactive',
        ]);

        $priority = new Priority();
        $priority->name = $request->name;
        $priority->status = $request->status;
        $priority->save();
        
        return redirect()->route('admin.priority.index')->with('success', 'Priority saved successfully!');
    }

    /**
     * Display the specified resource.
     */
    public function show(string $id)
    {
        $priority = priority::find($id);

        return view('admin.priority.show',[
            'priority' => $priority
        ]);
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(string $id)
    {
        $priority = Priority::find($id);

        return view('admin.priority.edit', [
            'priority' => $priority
        ]);
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(Request $request, string $id)
    {
        $request->validate([
            'name' => 'required|string|max:255|min:3|unique:priorities',
            'status' => 'required|in:active,inactive',
        ]);

        if (Priority::where('id', $id)->exists()) {
            
            $priority = Priority::findOrFail($id);
            
            $priority->name = $request->name;
            $priority->status = $request->status;
            
            $priority->save();

            return redirect()->route('admin.priority.index')->with('sucess', 'priority updated successfully!');
        } else {
            return redirect()->route('admin.priority.index')->with('error', 'priority not found.');
        }

    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(string $id)
    {
        if (Priority::where('id', $id)->exists()) {
            $priority = Priority::findOrFail($id);
            $priority->delete();

            return redirect()->route('admin.priority.index')->with('success', 'priority deleted successfully!');
        } else {
            return redirect()->route('admin.priority.index')->with('error', 'priority not found.');
        }
    }
}
