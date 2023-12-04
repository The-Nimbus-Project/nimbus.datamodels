export interface SFTPDetail {
    /**
     * MongoDB ObjectId
     */
    _id?:         string;
    address?:     string;
    isReachable?: boolean;
    key?:         string;
    name?:        string;
    /**
     * MongoDB ObjectId
     */
    organization_id?: string;
    passwordHash?:    string;
    userName?:        string;
    [property: string]: any;
}
