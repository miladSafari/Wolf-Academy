import { Course } from "./course.model";
import { Injectable } from "@angular/core";
import { Observable, of, BehaviorSubject } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { State } from "../../../../../node_modules/@progress/kendo-data-query";
import { GridDataResult } from "../../../../../node_modules/@progress/kendo-angular-grid";

@Injectable()
export class CourseGridService extends BehaviorSubject<GridDataResult> {
    private url = "http://localhost:5000/api/courses";
    
    constructor(private httpClient: HttpClient) {
        super(null);
    }

    reload(state:State){
        this.getAll(state).subscribe(x => super.next(x))
    }

    getAll(state: State): Observable<GridDataResult> {
       var skip = state.skip;
       var take = state.take;
       const getUrl = `${this.url}?skip=${skip}&take=${take}`;
       return this.httpClient.get<GridDataResult>(getUrl);
    }
}