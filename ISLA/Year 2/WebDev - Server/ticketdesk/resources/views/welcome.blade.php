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
    <body class="text-white bg-[#121212]">
        <div class="flex justify-center items-center">
            <div class="w-72 mt-10 border-2 border-white rounded-full
            bg-gradient-to-br from-emerald-400 to-yellow-300 hover:bg-gradient-to-tl">
                <p class="text-3xl text-center text-black font-bold py-2 px-4">   
                    <a href="{{ route('admin.index') }}">
                        Admin Dashboard
                    </a>
                </p>
            </div>
        </div>
    </body>
</html>
