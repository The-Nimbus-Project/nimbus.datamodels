export interface DataSegment {
    /**
     * MongoDB ObjectId
     */
    _id?:  string;
    code?: string;
    name?: string;
    [property: string]: any;
}
