export interface User {
    /**
     * MongoDB ObjectId
     */
    _id?: string;
    /**
     * List of MongoDB ObjectId
     */
    approvedDataSegment_ids?: string[];
    email?:                   string;
    firstName?:               string;
    isActive?:                boolean;
    isDeleted?:               boolean;
    lastName?:                string;
    middleInitial?:           string;
    /**
     * MongoDB ObjectId
     */
    organization_id?: string;
    passwordHash?:    string;
    phone?:           string;
    userName?:        string;
    [property: string]: any;
}
