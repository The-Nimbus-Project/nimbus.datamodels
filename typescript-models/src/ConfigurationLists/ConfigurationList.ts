export interface ConfigurationList {
    /**
     * MongoDB ObjectId
     */
    _id?:                      string;
    applicableDataSegmentIds?: string[];
    configurations?:           Configuration[];
    name?:                     string;
    readOnly?:                 boolean;
    [property: string]: any;
}

export interface Configuration {
    /**
     * MongoDB ObjectId
     */
    _id?:        string;
    descriptor?: string;
    details?:    Detail[];
    name?:       string;
    [property: string]: any;
}

export interface Detail {
    /**
     * MongoDB ObjectId
     */
    _id?:        string;
    descriptor?: string;
    identifier?: string;
    [property: string]: any;
}
