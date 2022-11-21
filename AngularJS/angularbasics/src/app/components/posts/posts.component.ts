import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Posts } from 'src/app/models/posts';
import { PostsService } from 'src/app/services/posts.service'

@Component({
  selector: 'app-posts',
  templateUrl: './posts.component.html',
  styleUrls: ['./posts.component.css']
})
export class PostsComponent implements OnInit {

  posts:Posts[]=[]
  constructor(private postsService:PostsService) { }

  ngOnInit(): void {
    console.log("PostsComponent:ngOnInit")
    this.postsService.getPosts().subscribe(posts=>{
      this.posts=posts
    })
  }
 
  addPost(post:NgForm):void{
    console.log(post.value)
    this.postsService.addPost(post.value).subscribe(post=>{
      console.log('add post###')
      console.log(post)
      this.posts.push(post)
 }
    )
}
}
