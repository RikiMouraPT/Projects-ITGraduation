@props(['categories'])

@extends('admin.index')

@section('content')

<div class="container">
    <a href="{{ route('admin.category.create') }}" 
    class="text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:ring-blue-300 font-medium rounded-lg text-sm px-5 py-2.5 focus:outline-none">
        Add new Category
    </a>
    
    </div>
    <div class="card-content">
        <table>
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Status</th>
                    <th>Level</th>
                    <th>Created</th>
                    <th>Updated</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                @foreach ($categories as $category)
                <tr>
                    <td data-label="Name">{{ $category->name }}</td>
                    <td data-label="Status">{{ $category->status }}</td>
                    <td data-label="Level">{{ $category->level->name }}</td>
                    <td data-label="Created">{{ $category->created_at }}</td>
                    <td data-label="Updated">{{ $category->updated_at }}</td>
                    <td class="actions-cell">
                        <div class="buttons right nowrap">
                            <a href="{{ route('admin.category.show', $category->id) }}" 
                            class="button blue">
                                <span>View</span>
                            </a>
                            <a href="{{ route('admin.category.edit', $category->id) }}" 
                            class="button blue">
                                <span>Edit</span>
                            </a>
                            <form method="POST" action="{{ route('admin.category.destroy', $category->id) }}">
                                @csrf
                                @method('DELETE')
                                <button type="submit" class="button red" onclick="return confirm('Are you sure you want to delete this category?');">
                                    <span>Delete</span>
                                </button>
                            </form>
                        </div>
                    </td>
                </tr>
                @endforeach
            </tbody>
        </table>
        <div class="table-pagination">
          <div class="flex items-center justify-between">
            <div class="buttons">
              <button type="button" class="button active">1</button>
              <button type="button" class="button">2</button>
              <button type="button" class="button">3</button>
            </div>
            <small>Page 1 of 3</small>
          </div>
        </div>
      </div>
    </div>
</div>

@endsection