import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http'
import { Posts } from '../models/posts';
import {Observable} from 'rxjs'

const httpOptions = {
  headers: new HttpHeaders({'Content-Type': 'application/json'})
}
@Injectable({
  providedIn: 'root'
})

  
export class PostsService {
  url:string="https://jsonplaceholder.typicode.com/posts"

  constructor(private httpClient:HttpClient) { }

  getPosts(){
    console.log("PostsServices:getPosts")
    return this.httpClient.get<Posts[]>(this.url)
  }

  addPost(data:Posts):Observable<Posts>{
    console.log("TodoService:addTodo")
    return this.httpClient.post<Posts>(this.url,data,httpOptions)
  }
}
