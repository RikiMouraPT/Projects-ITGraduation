<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Level extends Model
{
    /** @use HasFactory<\Database\Factories\LevelFactory> */
    use HasFactory;

    protected $fillable = [
        'name',
        'status'
    ];

    public function categories()
    {
        return $this->hasMany(Category::class);
    }
    public function tickets()
    {
        return $this->hasMany(Ticket::class);
    }
}
