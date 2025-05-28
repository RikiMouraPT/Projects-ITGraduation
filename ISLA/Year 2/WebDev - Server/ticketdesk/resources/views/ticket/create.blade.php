<!DOCTYPE html>
<html lang="{{ str_replace('_', '-', app()->getLocale()) }}">
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">

        <title>Laravel</title>

        <!-- Fonts -->
        <link rel="preconnect" href="https://fonts.bunny.net">
        <link href="https://fonts.bunny.net/css?family=figtree:400,500,600&display=swap" rel="stylesheet" />
        <!-- Styles / Scripts -->
        @vite(['resources/css/app.css', 'resources/js/app.js'])
        
    </head>
    <body class="text-gray-400 bg-gradient-to-br from-gray-900 to-gray-800 min-h-screen">
        <div class="max-w-md mx-auto px-4 py-12">
            <!-- Simple Logo/Header Area -->
            <div class="text-center mb-10">
                <h1 class="text-4xl font-bold text-transparent bg-clip-text bg-gradient-to-r from-purple-400 to-pink-500 mb-2">TicketDesk</h1>
                <p class="text-gray-400">Welcome to TicketDesk</p>
            </div>

            <div class="flex flex-col justify-center items-center space-y-6 bg-gray-800/50 p-8 rounded-2xl shadow-xl backdrop-blur-sm border border-gray-700">
                
                @if ($errors->any())
                    <div class="notification red">
                        <div class="flex flex-col md:flex-row items-center justify-between space-y-3 md:space-y-0">
                            <div>
                                <ul>
                                    @foreach ($errors->all() as $error)
                                        <li>{{ $error }}</li>
                                    @endforeach
                                </ul>
                            </div>
                        </div>
                    </div>
                @endif

                <form method="post" action="{{ route('ticket.store') }}" class="w-full space-y-4">
                    @csrf
            
                    <div>
                        <label class="block text-sm font-medium text-gray-300 mb-1">Title</label>
                        <input type="text" name="title" required placeholder="Title"
                            class="w-full px-4 py-2 rounded-xl bg-gray-900 text-white border border-gray-600 focus:outline-none focus:ring-2 focus:ring-purple-500 placeholder-gray-500 transition">
                    </div>
            
                    <div>
                        <label class="block text-sm font-medium text-gray-300 mb-1">Description</label>
                        <textarea name="description" rows="4" required placeholder="Description"
                            class="w-full px-4 py-2 rounded-xl bg-gray-900 text-white border border-gray-600 focus:outline-none focus:ring-2 focus:ring-purple-500 placeholder-gray-500 transition"></textarea>
                    </div>
            
                    <div>
                        <label class="block text-sm font-medium text-gray-300 mb-1">Category</label>
                        <select name="category_id" required
                            class="w-full px-4 py-2 rounded-xl bg-gray-900 text-white border border-gray-600 focus:outline-none focus:ring-2 focus:ring-emerald-500 transition">
                            <option value="">Choose a category</option>
                            @foreach ($categories as $category)
                                <option value="{{ $category->id }}">{{ $category->name }}</option>
                            @endforeach
                        </select>
                    </div>
            
                    <div>
                        <label class="block text-sm font-medium text-gray-300 mb-1">Priority</label>
                        <select name="priority_id" required
                            class="w-full px-4 py-2 rounded-xl bg-gray-900 text-white border border-gray-600 focus:outline-none focus:ring-2 focus:ring-yellow-500 transition">
                            <option value="">Choose a priority</option>
                            @foreach ($priorities as $priority)
                                <option value="{{ $priority->id }}">{{ $priority->name }}</option>
                            @endforeach
                        </select>
                    </div>
            
                    <div class="flex justify-between mt-6">
                        <button type="submit"
                            class="px-6 py-2 rounded-xl bg-emerald-600 hover:bg-emerald-700 text-white font-semibold transition">
                            New Ticket
                        </button>
                        <button type="reset"
                            class="px-6 py-2 rounded-xl bg-red-600 hover:bg-red-700 text-white font-semibold transition">
                            Clear
                        </button>
                    </div>
                </form>
            </div>
            <!-- Button to go back to the main page -->
            <div class="mt-10 text-center">
                <a href="{{ route('welcome') }}" class="inline-block px-6 py-3 bg-gradient-to-r from-gray-500 to-gray-400 hover:from-gray-600 hover:to-gray-500 text-white font-semibold rounded-lg shadow-lg transition duration-300">
                    Back
                </a>
            </div>
    </body>
</html>
