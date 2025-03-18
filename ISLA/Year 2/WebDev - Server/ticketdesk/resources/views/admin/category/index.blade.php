@props(['categories'])


<div class="container">
    <h1>Category List</h1>
    <ul>
        @foreach($categories as $category)
            <li>{{ $category['name'] ?? 'Unnamed Category' }}</li>
        @endforeach
    </ul>
</div>