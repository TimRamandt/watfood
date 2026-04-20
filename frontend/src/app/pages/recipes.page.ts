import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NonNullableFormBuilder, Validators, ReactiveFormsModule } from '@angular/forms';
import { z } from 'zod';

const Recipe = z.object({
  name: z.string(),
});
type Recipe = z.infer<typeof Recipe>;


@Component({
  selector: 'recipes',
  templateUrl: 'recipes.html',
  imports: [CommonModule, ReactiveFormsModule],
})
export class RecipePage {
    constructor(private fb: NonNullableFormBuilder) {}

    addRecipeForm = this.fb.group({
      name: ['', [Validators.required]]
    })
    
    get name() {
      return this.addRecipeForm.controls.name
    }

    async onSubmit () {
      if (this.addRecipeForm.invalid) {
        this.addRecipeForm.markAllAsTouched()
        return;
      }

      const recipe = z.safeParse(Recipe, this.addRecipeForm.getRawValue()).data
      console.log(JSON.stringify(recipe))
      const res = await fetch('http://localhost:5000/recipes', {
        method: 'POST',
        headers: {
           'Content-Type': 'application/json',
          },
        body: JSON.stringify(recipe)
      })
    }

}