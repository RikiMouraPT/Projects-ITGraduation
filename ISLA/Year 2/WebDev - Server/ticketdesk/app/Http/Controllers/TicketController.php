<?php

namespace App\Http\Controllers;

use App\Models\Ticket;
use App\Models\Category;
use App\Models\Priority;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\DB;

class TicketController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        if(Auth::check() && Auth::User()->role == 'agent')
        {      
            /*$tickets = Ticket::with(['priority', 'category'])
                ->where('user_id', Auth::id())
                ->get();*/

            $tickets = DB::table('tickets')
                ->join('priorities', 'tickets.priority_id', '=', 'priorities.id')
                ->join('categories', 'tickets.category_id', '=', 'categories.id')
                ->select('tickets.*', 'priorities.name as priority_name', 'categories.name as category_name')
                ->where('categories.level_id', Auth::user()->level_id)
                ->get();
        }
        else if (Auth::check() && Auth::User()->role == 'user')
        {
            //Tickets using the DB facade to get all tickets of the logged-in user
            $tickets = DB::table('tickets')
                ->join('priorities', 'tickets.priority_id', '=', 'priorities.id')
                ->join('categories', 'tickets.category_id', '=', 'categories.id')
                ->select('tickets.*', 'priorities.name as priority_name', 'categories.name as category_name')
                ->where('tickets.user_id', Auth::id())
                ->get();
        }
        else
        {
            $tickets = [];
        }


        return view('welcome', compact('tickets'));
    }

    /**
     * Show the form for creating a new resource.
     */
    public function create()
    {
        $categories = Category::all();
        $priorities = Priority::all();
        return view('ticket.create', compact('categories', 'priorities'));
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(Request $request)
    {
        $request->validate([
            'title' => 'required|string|max:255',
            'description' => 'required|string',
            'category_id' => 'required|exists:categories,id',
            'priority_id' => 'required|exists:priorities,id',
        ]);

        $ticket = new Ticket();
        $ticket->title = $request->title;
        $ticket->description = $request->description;
        $ticket->category_id = $request->category_id;
        $ticket->priority_id = $request->priority_id;
        $ticket->user_id = Auth::user()->id;
        $ticket->status = 'open';
        $ticket->save();

        return redirect()->route('ticket.index')->with('success', 'Ticket created successfully.');
    }

    /**
     * Display the specified resource.
     */
    public function show(Ticket $ticket)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(Ticket $ticket)
    {
        $categories = Category::all();
        $priorities = Priority::all();
        return view('ticket.edit', compact('ticket', 'categories', 'priorities'));
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(Request $request, Ticket $ticket)
    {
        $request->validate([
            'title' => 'required|string|max:255',
            'description' => 'required|string',
            'category_id' => 'required|exists:categories,id',
            'priority_id' => 'required|exists:priorities,id',
        ]);

        $ticket->title = $request->title;
        $ticket->description = $request->description;
        $ticket->category_id = $request->category_id;
        $ticket->priority_id = $request->priority_id;
        $ticket->save();
        
        return redirect()->route('ticket.index')->with('success', 'Ticket updated successfully.');
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(Ticket $ticket)
    {
        $ticket->delete();
        return redirect()->route('ticket.index')->with('success', 'Ticket deleted successfully.');
    }
}
