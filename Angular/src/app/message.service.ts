import 'rxjs/add/observable/of';
import 'rxjs/add/operator/map';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { HttpClient, HttpHeaders } from '@angular/common/http';

export class Message {
  constructor(public id: number, public message: string) { }
}
const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type':  'application/json'
  })
};
const MESSAGES = [];
@Injectable()
export class MessageService {

  constructor(private http: HttpClient) { }
  getMessages() { 
    // return Observable.of(MESSAGES);
    return this.http.get('http://tj.nextpageit.net/stefano/Api/GetAllMessages');
   }

  postMessage(data){
    // let message = new Message(data.id, data.message);
    
    // MESSAGES.push(message);
      let message  = {
        'Message':data.message
      }
    return this.http.post('http://tj.nextpageit.net/stefano/Api/SaveMessage',message, httpOptions)
  }
}
