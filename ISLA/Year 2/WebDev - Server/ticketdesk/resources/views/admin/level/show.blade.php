@extends('admin.index')

@section('content')

<form>
    <div class="field">
      <label class="label">Name</label>
      <div class="field-body">
        <div class="field">
          <div class="control">
            <input class="input" type="text" placeholder="Name" name='name' value="{{ $level->name }}" disabled>
          </div>
        </div>
      </div>
    </div>
    <div class="field">
      <label class="label">Status</label>
      <div class="control">
        <input class="input" type="text" placeholder="Name" name='name' value="{{ ucfirst($level->status) }}" disabled>
      </div>
      <!-- 
      <div class="control">
        <div class="select">
          <select name='status' disabled>
            <option>Select a Status
              <option {{ $level->status == 'active' ? 'selected' : '' }}>Active</option>
              <option {{ $level->status == 'inactive' ? 'selected' : '' }}>Inactive</option>
          </select>
        </div>
      </div>
      -->
    </div>

    <hr class="my-5">

    <div class="field grouped">
      <div class="control">
        <a href="{{ route('admin.level.index') }}" class="button blue">
          <span>Voltar</span>
        </a>
      </div>
    </div>
  </form>

@endsection