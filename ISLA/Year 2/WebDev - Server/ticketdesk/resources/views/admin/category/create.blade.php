@extends('admin.index')

@section('content')

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

<form method="post" action="{{ route('admin.category.store') }}">
  @csrf
    <div class="field">
      <label class="label">Name</label>
      <div class="field-body">
        <div class="field">
          <div class="control icons-left">
            <input class="input" type="text" placeholder="Name" name='name' required>
          </div>
        </div>
      </div>
    </div>
    <div class="field">
      <label class="label">Level</label>
      <div class="control">
        <div class="select">
          <select name='level_id' required>
            <option>Select a Level
            @foreach ($levels as $level)
            <option value="{{ $level->id }}">{{ $level->name }}</option>
            @endforeach
          </select>
        </div>
      </div>
    </div>
    <div class="field">
      <label class="label">Status</label>
      <div class="control">
        <div class="select">
          <select name='status' required>
            <option>Select a Status
            <option value="active">Active</option>
            <option value="inactive">Inactive</option>
          </select>
        </div>
      </div>
    </div>

    <hr class="my-5">

    <div class="field grouped">
      <div class="control">
        <button type="submit" class="button green">
          Submit
        </button>
      </div>
      <div class="control">
        <button type="reset" class="button red">
          Reset
        </button>
      </div>
    </div>
  </form>

@endsection