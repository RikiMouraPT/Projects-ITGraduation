@extends('admin.index')

@section('content')

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
      <label class="label">Status</label>
      <div class="control">
        <div class="select">
          <select name='status' required>
            <option>Select a Status
            <option>Active</option>
            <option>Inactive</option>
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