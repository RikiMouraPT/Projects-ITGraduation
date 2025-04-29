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
    <body class="text-gray-100 bg-gradient-to-br from-gray-900 to-gray-800 min-h-screen">
        <div class="max-w-md mx-auto px-4 py-12">
            <!-- Simple Logo/Header Area -->
            <div class="text-center mb-10">
                <h1 class="text-4xl font-bold text-transparent bg-clip-text bg-gradient-to-r from-purple-400 to-pink-500 mb-2">TicketDesk</h1>
                <p class="text-gray-400">Welcome to TicketDesk</p>
            </div>

            <div class="flex flex-col justify-center items-center space-y-6 bg-gray-800/50 p-8 rounded-2xl shadow-xl backdrop-blur-sm border border-gray-700">
                @auth
                    <!-- Botão para Admin Dashboard -->
                    <div class="w-full">
                        <a href="{{ route('admin.index') }}" class="block w-full text-center rounded-xl bg-gradient-to-r from-emerald-500 to-teal-400 hover:from-emerald-600 hover:to-teal-500 transition-all duration-300 shadow-lg shadow-emerald-500/20">
                            <p class="text-2xl text-white font-bold py-3 px-4">   
                                Admin Dashboard
                            </p>
                        </a>
                    </div>

                    <!-- Nome do Utilizador Autenticado -->
                    <div class="mt-6 text-xl font-semibold">
                        <span class="px-6 py-2 bg-gray-700 text-gray-100 rounded-full shadow-inner border border-gray-600 flex items-center justify-center">
                            <span class="text-purple-400 mr-2">@</span>{{ Auth::user()->name }}
                        </span>
                    </div>

                    <!-- Botão de Logout -->
                    <form method="POST" action="{{ route('logout') }}" class="mt-4 w-full">
                        @csrf
                        <button type="submit"
                            class="w-full rounded-xl bg-gradient-to-r from-rose-500 to-pink-500 hover:from-rose-600 hover:to-pink-600 text-xl text-white font-bold py-3 px-4 transition-all duration-300 shadow-lg shadow-rose-500/20">
                            Logout
                        </button>
                    </form>
                @else
                    <!-- Login -->
                    <div class="w-full">
                        <a href="{{ route('login') }}" class="block w-full text-center rounded-xl bg-gradient-to-r from-blue-500 to-indigo-500 hover:from-blue-600 hover:to-indigo-600 transition-all duration-300 shadow-lg shadow-blue-500/20">
                            <p class="text-2xl text-white font-bold py-3 px-4">   
                                Login
                            </p>
                        </a>
                    </div>

                    <!-- Register -->
                    <div class="w-full mt-4">
                        <a href="{{ route('register') }}" class="block w-full text-center rounded-xl bg-gradient-to-r from-purple-500 to-pink-500 hover:from-purple-600 hover:to-pink-600 transition-all duration-300 shadow-lg shadow-purple-500/20">
                            <p class="text-2xl text-white font-bold py-3 px-4">   
                                Registar
                            </p>
                        </a>
                    </div>
                @endauth
            </div>
            @auth
                <!-- Ticket Area -->

                <!-- Create New Ticket -->
                <div class="mt-10 text-center">
                    <a href="{{ route('ticket.create') }}" class="inline-block px-6 py-3 bg-gradient-to-r from-green-500 to-green-400 hover:from-green-600 hover:to-green-500 text-white font-semibold rounded-lg shadow-lg transition duration-300">
                        New Ticket
                    </a>
                </div>
                <!-- Ticket List -->
                <div class="mt-6">
                    <h2 class="text-2xl font-semibold text-center mb-4 text-white">Tickets</h2>
                    <ul class="space-y-4">
                        @forelse ($tickets as $ticket)
                            <li class="bg-gray-800 p-6 rounded-xl shadow-lg hover:shadow-xl transition duration-300">
                                <div class="flex items-center justify-between">
                                    <a href="{{ route('ticket.show', $ticket->id) }}" class="text-xl font-bold text-emerald-300 hover:underline">
                                        {{ $ticket->title }}
                                    </a>
                                    <div class="flex items-center space-x-4">
                                        <span class="text-sm text-gray-400">{{ $ticket->date }}</span>
                                        <span class="px-3 py-1 text-sm font-medium rounded-full 
                                            {{ $ticket->status === 'open' ? 'bg-green-600' : 'bg-red-600' }} text-white">
                                            {{ ucfirst($ticket->status) }}
                                        </span>

                                    </div>
                                </div>

                                <div class="mt-4 flex flex-row flex-wrap gap-2">
                                    <span class="px-3 py-1 text-sm font-medium rounded-full bg-blue-600 text-white">
                                        Priority: {{ $ticket->priority_name }}
                                    </span>
                                    <span class="px-3 py-1 text-sm font-medium rounded-full bg-purple-600 text-white">
                                        Category: {{ $ticket->category_name }}
                                    </span>
                                </div>
                                <p class="text-gray-300 mt-2">{{ Str::limit($ticket->description, 100) }}</p>
                            </li>
                        @empty
                            <li class="bg-gray-800 p-6 rounded-xl shadow-lg text-center text-gray-300">
                                No Ticket available.
                            </li>
                        @endforelse
                    </ul>
                </div>

            @endauth
            <!-- Footer -->
            <div class="mt-10 text-center text-gray-500 text-sm">
                <p>© {{ date('Y') }} Ricardo Moura. All rights reserved.</p>
            </div>
        </div>
    </body>
</html>