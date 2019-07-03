import { Component } from '@angular/core';
import { CourseCategory } from '../shared/course-category.model';

@Component({
    selector: ' <course-category-list> ',
    templateUrl: './course-category-list.Component.html'
})
export class CourseCategoryListComponent {
    courseCategories: Array<CourseCategory>;
    constructor() {
       this.courseCategories = new Array<CourseCategory>();
       this.courseCategories.push(new CourseCategory(1, 'web programming'));
       this.courseCategories.push(new CourseCategory(2, 'Mobile programming'));
    }
}
