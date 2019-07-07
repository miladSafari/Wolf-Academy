import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { CourseCategoryListComponent } from './course-categories/course-category-list/course-category-list.component';
import { CourseCategoryComponent } from './course-categories/course-category/course-category.component';
import { RouterModule, Routes } from '@angular/router';
import {CourseCategoryService} from './course-categories/shared/course-category.service';
import {HttpClientModule} from '@angular/common/http';
// import { FormsModule } from '@angular/forms';
// import { HttpClientModule } from '@angular/common/http';

// import { AppComponent } from './app.component';
// import { ItemDirective } from './item.directive';
const appRoutes: Routes = [
    { path: 'course-category-list', component: CourseCategoryListComponent },
    { path: 'course-category', component: CourseCategoryComponent },
  ];

// @NgModule decorator with its metadata
@NgModule({
    imports:       [ BrowserModule ,
    HttpClientModule,
    RouterModule.forRoot(appRoutes)
    ],
    providers:     [ CourseCategoryService ],
    declarations:  [
        CourseCategoryListComponent,
        CourseCategoryComponent
     ],
    exports:       [ ],
    bootstrap:     [  ]
})
export class AcademyModule { }
