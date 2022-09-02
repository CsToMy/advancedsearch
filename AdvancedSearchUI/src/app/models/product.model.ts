import { Dimension } from "./dimension.model";

export class Product {
    public id: number;
    public name: string;
    public category: string;
    public description: string;
    public price: number;
    public dimensions: Dimension;

    constructor(
    id: number,
    name: string,
    category: string,
    description: string,
    price: number,
    dimensions: Dimension) {
        this.id = id;
        this.name = name;
        this.category = category;
        this.price = price;
        this.dimensions = dimensions;
        this.description = description;
     }
}