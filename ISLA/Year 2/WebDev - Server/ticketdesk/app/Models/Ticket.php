<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Ticket extends Model
{
    /** @use HasFactory<\Database\Factories\TicketFactory> */
    use HasFactory;

    protected $fillable = [
        'title',
        'description',
        'category_id',
        'priority_id',
        'level_id',
        'user_id',
        'status',
        'closed_at'
    ];
    public function category()
    {
        return $this->belongsTo(Category::class);
    }
    public function priority()
    {
        return $this->belongsTo(Priority::class);
    }
    public function level()
    {
        return $this->belongsTo(Level::class);
    }
    public function user()
    {
        return $this->belongsTo(User::class);
    }
}